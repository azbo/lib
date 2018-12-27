using System.Data;

namespace Lib
{
    public interface IDb
    {
        int insert(DataParams data);

        int remove(DataParams data);

        int modify(DataParams data);

        DataTable Query(DataParams data);
    }
}
