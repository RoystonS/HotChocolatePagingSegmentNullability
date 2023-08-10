using HotChocolate;

namespace HotChocolateIssue;

public class Query
{
    public Root GetRoot()
    {
        return new Root();
    }
}

public class Root
{
    [UseOffsetPaging(IncludeTotalCount = true, MaxPageSize = 100, DefaultPageSize = 100)]
    public IQueryable<Value> GetValues([Parent] Root root)
    {
        return new List<Value>().AsQueryable();
    }
}

public class Value
{
    public int Property { get { return 42; } }
}

