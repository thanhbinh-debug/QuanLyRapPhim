namespace QuanLyRapPhim.Models
{
    public class MCombo
    {
         #region Combo
        private string tenCombo;
        private List<MSanPham> danhSachSP= new List<MSanPham>();
        private double giaCombo;
        #endregion

        #region Property Combo
        public string TenCombo
        {
            get { return tenCombo; }
            set { tenCombo = value; }
        }

        public double GiaCombo
        {
            get { return giaCombo; } 
            set { giaCombo = value; }   
        }

        public List<MSanPham> DanhSachSP
        {
            get { return danhSachSP; }
            set { danhSachSP = value; }
        }
        #endregion 
    }
}
