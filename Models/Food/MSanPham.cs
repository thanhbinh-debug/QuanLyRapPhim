namespace QuanLyRapPhim.Models
{
    public class MSanPham
    {
        #region SanPham
        private int maSP;
        private string tenSP; 
        private double gia;
        #endregion

        #region Property SanPham
        public int MaSP
        {
            get { return maSP; }
            set { maSP = value; }
        }
        public string TenSP
        {
            get { return tenSP; }
            set { tenSP = value; }
        }
        public double Gia
        {
            get { return gia; }
            set { gia = value; }
        }
        #endregion

    }
}
