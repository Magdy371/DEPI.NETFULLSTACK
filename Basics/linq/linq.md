```markdown
# LINQ in C#

**LINQ** (Language Integrated Query) lets you query collections, XML, and databases with the same C# syntax.

It is **not** only “40 methods.” It is:

1. **Query operators** (Where, Select, OrderBy, …)
2. Implemented mostly as **extension methods**
3. Two execution models: **in memory** (`IEnumerable<T>`) and **translated queries** (`IQueryable<T>`)
4. Two syntaxes: **method syntax** and **query syntax**

In .NET 3.5 there were roughly **40 operators**. Today there are more (`Chunk`, `DistinctBy`, `MinBy`, `MaxBy`, …).

---

## Prerequisites (why LINQ looks the way it does)

LINQ is built on features you already practiced:

| Feature | Role in LINQ |
|---|---|
| `var` | Infer the type of query results |
| Anonymous types | `Select(x => new { x.Id, x.Name })` |
| Extension methods | `Where`, `Select` are `this IEnumerable<T>` methods |
| Delegates / lambdas | `x => x.Salary > 1000` is a `Func<T, bool>` |
| `yield return` | Many operators stream results (deferred execution) |

`Where` is conceptually:

```csharp
public static IEnumerable<T> Where<T>(this IEnumerable<T> source, Func<T, bool> predicate)
{
    foreach (var item in source)
        if (predicate(item))
            yield return item;
}
```

Because of `this IEnumerable<T>`, you call it as `list.Where(...)`.

---

## The two main surfaces

### 1. LINQ to Objects — `IEnumerable<T>`

- Namespace: `System.Linq`
- Class: `Enumerable`
- Runs **in the current process**, in C#
- Works on arrays, `List<T>`, `Dictionary<TKey,TValue>`, anything that implements `IEnumerable<T>`

### 2. LINQ to Queries / providers — `IQueryable<T>`

- Class: `Queryable`
- Same method names (`Where`, `Select`, …)
- Lambdas are stored as **expression trees** (`Expression<Func<...>>`)
- A provider (EF Core, etc.) **translates** them to SQL (or another query language)

```csharp
IEnumerable<Employee> local = employees.Where(e => e.Salary > 1000); // C# loop
IQueryable<Employee> db = context.Employees.Where(e => e.Salary > 1000); // becomes SQL
```

Same C# code, different execution.

---

## LINQ flavors (common names)

| Name | What you query | Typical type |
|---|---|---|
| LINQ to Objects | In-memory collections | `IEnumerable<T>` |
| LINQ to XML | XML documents | `XDocument` / `XElement` (then `IEnumerable`) |
| LINQ to Entities / EF | Relational DB via Entity Framework | `IQueryable<T>` on `DbSet<T>` / `DbContext` |
| LINQ to SQL | Older Microsoft ORM | `DataContext` (not `DbContext`) |

Notes:

- **EF Core** uses `DbContext` and `DbSet<T>` (`IQueryable<T>`).
- **Classic LINQ to SQL** uses `System.Data.Linq.DataContext`.
- **Old Entity Framework** used `ObjectContext` (“LINQ to Entities”).
- LINQ to XML is still LINQ to Objects over XML nodes; `XElement` is enumerable.

---

## Two syntaxes (same operators)

```csharp
int[] numbers = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };

// Query syntax (SQL-like, compiled into method calls)
var q1 =
    from n in numbers
    where n % 2 == 0
    orderby n
    select n * n;

// Method syntax (extension methods)
var q2 = numbers
    .Where(n => n % 2 == 0)
    .OrderBy(n => n)
    .Select(n => n * n);
```

Query syntax is **sugar**. The compiler turns `from` / `where` / `select` into `Select`, `Where`, `SelectMany`, etc.

Some operators exist **only** in method syntax (`Count`, `First`, `ToList`, `DistinctBy`, …).

---

## Deferred vs immediate execution

Most operators return `IEnumerable<T>` / `IQueryable<T>` and **do not run** until you enumerate:

```csharp
var query = numbers.Where(n => n > 5); // nothing runs yet
foreach (var n in query) { }           // now it runs
```

**Immediate** operators force execution and return a value or a concrete collection:

- Element: `First`, `FirstOrDefault`, `Single`, `Last`, `ElementAt`
- Aggregate: `Count`, `Sum`, `Min`, `Max`, `Average`, `Aggregate`
- Materialize: `ToList`, `ToArray`, `ToDictionary`, `ToHashSet`

```csharp
List<int> list = numbers.Where(n => n > 5).ToList(); // runs now
```

Re-enumerating a deferred query **runs it again**. For `IQueryable`, that can mean **another SQL round-trip**.

---

## Streaming vs buffering

- **Streaming:** `Where`, `Select` — one item at a time (`yield return`)
- **Buffering:** `OrderBy`, `GroupBy`, `Distinct` — need (almost) the whole sequence first

---

## Operator groups (the “~40” operators)

### Filtering

- `Where` — keep items that match a predicate
- `OfType<T>` — keep items of a given type
- `Skip` / `Take` / `SkipWhile` / `TakeWhile` — paging / windows
- `Distinct` / `DistinctBy`

### Projection

- `Select` — map each item
- `SelectMany` — flatten nested sequences (this is what nested `from` becomes)

```csharp
var names = employees.Select(e => e.Name);
var allPhones = employees.SelectMany(e => e.Phones);
```

### Ordering

- `OrderBy` / `OrderByDescending`
- `ThenBy` / `ThenByDescending`
- `Reverse`

### Joining

- `Join` — inner join
- `GroupJoin` — grouped join (left-join style)
- `Zip` — pair by position

### Grouping

- `GroupBy`

```csharp
var byDept = employees.GroupBy(e => e.Department);
foreach (var g in byDept)
{
    Console.WriteLine(g.Key);
    foreach (var e in g)
        Console.WriteLine(e.Name);
}
```

### Set operations

- `Union`, `Intersect`, `Except`, `Concat`

### Quantifiers

- `Any`, `All`, `Contains`

### Elements

- `First` / `FirstOrDefault`
- `Single` / `SingleOrDefault`
- `Last` / `LastOrDefault`
- `ElementAt` / `ElementAtOrDefault`
- `DefaultIfEmpty`

### Aggregation

- `Count` / `LongCount`
- `Sum`, `Min`, `Max`, `Average`
- `Aggregate`
- `MinBy` / `MaxBy` (.NET 6+)

### Generation

- `Range`, `Repeat`, `Empty`

### Conversion

- `ToList`, `ToArray`, `ToDictionary`, `ToLookup`, `AsEnumerable`, `AsQueryable`, `Cast`

---

## `IEnumerable<T>` vs `IQueryable<T>` (important)

```csharp
// In memory: Func<T, bool> — a real C# method
bool IsRich(Employee e) => e.Salary > 10_000 && SomeLocalHelper(e);

employees.Where(IsRich); // OK for List<Employee>

// EF: Expression<Func<T, bool>> — must be translatable to SQL
context.Employees.Where(e => e.Salary > 10_000); // OK
context.Employees.Where(e => SomeLocalHelper(e)); // often fails or pulls too much data
```

Rules of thumb:

- Keep filters on `IQueryable` so they run in the database.
- Call `ToList()` / `AsEnumerable()` only when you **intend** to switch to in-memory LINQ.
- `AsEnumerable()` stops SQL translation; later `Where` runs in C#.

---

## Query variable vs result

```csharp
IEnumerable<int> query = numbers.Where(n => n > 3).Select(n => n * 2);
int[] result = query.ToArray();
```

- `query` is a **recipe**
- `result` is **data**

---

## Anonymous types in projections

```csharp
var cards = employees.Select(e => new { e.Id, e.Name });
```

The compiler creates an immutable class. Useful for shaping query results without a DTO. For public APIs, prefer a named type.

---

## Common pitfalls

1. **Multiple enumeration** — a deferred query runs every time you `foreach` / `Count()` / `ToList()`.
2. **`First` vs `FirstOrDefault`** — `First` throws if empty.
3. **`Single` vs `First`** — `Single` throws if more than one match.
4. **`==` on anonymous types** — they override `Equals` (value equality), not always `==` for reference types in older patterns; prefer `Equals`.
5. **EF + client methods** — custom C# methods inside `Where` often cannot become SQL.
6. **Deferred + changing source** — if the list changes before you enumerate, the query sees the new data.

---

## Minimal examples

```csharp
using System.Linq;

var employees = new List<Employee>
{
    new() { Id = 1, Name = "Magdy", Salary = 45000 },
    new() { Id = 2, Name = "Ahmed", Salary = 50000 },
    new() { Id = 3, Name = "Sara",  Salary = 20000 },
};

var highEarners =
    from e in employees
    where e.Salary > 30000
    orderby e.Salary descending
    select new { e.Name, e.Salary };

foreach (var x in highEarners)
    Console.WriteLine($"{x.Name}: {x.Salary}");

double avg = employees.Average(e => e.Salary);
bool anyPoor = employees.Any(e => e.Salary < 25000);
Employee? first = employees.FirstOrDefault(e => e.Name.StartsWith("A"));
```

---

## One-sentence summary

**LINQ is a standard set of query operators (originally ~40), exposed as extension methods on `IEnumerable<T>` and `IQueryable<T>`, with optional SQL-like query syntax, deferred execution, and providers that run the same queries in memory or against a data source.**
```

---

Switch to **Agent mode** if you want this saved as `/home/magdy/Documents/dotnet/linq/LINQ.md`.

Also, two comments in `Program.cs` are off: LINQ to SQL uses **`DataContext`**, not `DbContext`; `DbContext` is Entity Framework. LINQ to Entities historically used **`ObjectContext`**; modern EF uses `DbContext`.