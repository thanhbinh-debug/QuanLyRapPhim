namespace QuanLyRapPhim.Models
{
    public class MPhim
    {
        #region Phimmmm
        private string maPhim;
        private string tenPhim;
        private string theLoai;
        private int thoiLuong;
        #endregion

        //khai property để có thể truy xuất sửa đổi dữ liệu
        #region Property Phimmmm
        public string MaPhim
        {
            get { return maPhim; } 
            set { maPhim = value; } 
        }

        public string TenPhim
        {
            get { return tenPhim; } 
            set { tenPhim = value; } 
        }

        public string TheLoai
        {
            get { return theLoai; } 
            set { theLoai = value; } 
        }

        public int ThoiLuong
        {
            get { return thoiLuong; } 
            set { thoiLuong = value; }
        }
        #endregion  
    }
}
