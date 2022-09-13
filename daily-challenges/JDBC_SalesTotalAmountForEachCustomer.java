import java.sql.*;

public class Hello
{
    public static void executeQuery(Connection conn, Scanner sc)
    {
        //Not the best solution..Not even a good one...But still works
        try
        {
            var stmt = conn.createStatement();
            var names = stmt.executeQuery("select distinct name from sales order by name;");
            while(names.next())
            {
                var saleStmt = conn.prepareStatement("select sum(amount) from sales where name=?");
                saleStmt.setString(1, names.getString("name"));
                var sale = saleStmt.executeQuery();
                while(sale.next())
                    System.out.println(names.getString("name") + " " + sale.getString(1));
            }
        }
        catch(Exception e)
        {

        }
    }

    public static void main()
    {
        //Already implemented to open and close connections
    }
}