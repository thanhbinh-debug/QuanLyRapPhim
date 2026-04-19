using QuanLyRapPhim.Data;
using QuanLyRapPhim.Models;
using System.Data;

namespace QuanLyRapPhim.Controllers
{
    public class CSuatChieu
    {
        private String tableName = "suatchieu";
        private CDataAccess da = new CDataAccess();

        public DataTable GetAll(String dieuKien)
        {
            String query = "SELECT * FROM " + tableName;
            if (dieuKien.Length > 0)
            {
                query += " WHERE " + dieuKien;
            }
            query += " ORDER BY ID ASC";

            return da.Doc(query);
        }

        public DataTable GetAll()
        {
            return GetAll("");
        }

        private List<MSuatChieu> TableToList(DataTable tb)
        {
            List<MSuatChieu> ds = new List<MSuatChieu>();
            if (tb != null && tb.Rows.Count > 0)
            {
                foreach (DataRow dr in tb.Rows)
                {
                    var m = new MSuatChieu();
                    m.Phim = (dr["MaPhim"].ToString());
                    m.Phong = dr["MaPhong"].ToString();
                    m.ThoiGian = dr["ThoiGian"] != DBNull.Value
                        ? DateTime.Parse(dr["ThoiGian"].ToString())
                        : DateTime.MinValue;

                    ds.Add(m);
                }
            }
            return ds;
        }

        public List<MSuatChieu> GetList(String dieuKien)
        {
            return TableToList(GetAll(dieuKien));
        }

        public MSuatChieu GetByID(int id)
        {
            var ds = GetList("ID=" + id);
            if (ds != null && ds.Count > 0)
            {
                return ds[0];
            }
            else
            {
                return null;
            }
        }

        public int Insert(MSuatChieu m)
        {
            String query = "INSERT INTO " + tableName + " (MaPhim, MaPhong, ThoiGian) VALUES (";
            query += "'" + m.Phim + "', ";
            query += "'" + m.Phong + "', ";
            query += "'" + m.ThoiGian.ToString("yyyy-MM-dd HH:mm:ss") + "')";
            return da.Ghi(query);
        }

        public int Update(MSuatChieu m)
        {
            String query = "UPDATE " + tableName + " SET ";
            query += "MaPhim = N'" + m.Phim + "', ";
            query += "MaPhong = N'" + m.Phong + "', ";
            query += "ThoiGian = '" + m.ThoiGian.ToString("yyyy-MM-dd HH:mm:ss") + "' ";
            query += "WHERE MaPhim = N'" + m.Phim + "'"; 
            return da.Ghi(query);
        }

        public int Delete(int id)
        {
            String query = "DELETE FROM" + tableName + " WHERE ID=" + id;
            return da.Ghi(query);
        }

    }
}
