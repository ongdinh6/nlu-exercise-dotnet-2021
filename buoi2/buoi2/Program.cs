using System;
using System.Collections;
using System.Diagnostics.CodeAnalysis;

namespace buoi2
{
    
    class SinhVien :IComparable<SinhVien>
    {
       public int MaSV { set; get; }
        public string HoLot { set; get; }
        public string Ten { set; get; }
       public string NgaySinh { set; get; }
        public string GioiTinh { set; get; }
        public string DiaChi { set; get; }
        ArrayList DSMonHoc { set; get; }

        public SinhVien()
        {
            this.MaSV = 000;
        }
        public SinhVien(int MaSV, string HoLot, string Ten, string NgaySinh, string GioiTinh, string DiaChi, ArrayList DSMonHoc)
        {
            this.MaSV = MaSV;
            this.HoLot = HoLot;
            this.Ten = Ten;
            this.NgaySinh = NgaySinh;
            this.GioiTinh = GioiTinh;
            this.DiaChi = DiaChi;
            this.DSMonHoc = DSMonHoc;
        }

        public override string ToString()
        {
            return "Sinh vien: " + MaSV + ", ho va ten = " + HoLot + " " + Ten + ", ngay sinh = " + NgaySinh + ", gioi tinh = " + GioiTinh + ", dia chi = " + DiaChi;

        }


        public int CompareTo([AllowNull] SinhVien other)
        {
            return this.Ten.CompareTo(other.Ten);
        }
    }
    class MonHoc
    {
        int MaMH { set; get; }
        string TenMH { set; get; }
        int SoTC { set; get; }
        double Diem { set; get; }

        public MonHoc()
        {

        }
        public MonHoc(int MaMH, string TenMH, int SoTC, double diem)
        {
            this.MaMH = MaMH;
            this.TenMH = TenMH;
            this.SoTC = SoTC;
            this.Diem = Diem;
        }
    }
    class Program
    {
        ArrayList DSSinhVien = new ArrayList();


        public void init()
        {
            this.DSSinhVien = new ArrayList();
            ArrayList DSMonHocCua101 = new ArrayList();
            DSMonHocCua101.Add(new MonHoc(901, "LAP TRINH .NET", 4, 9.6));
            DSMonHocCua101.Add(new MonHoc(902, "CHUYEN DE JAVA", 4, 9.6));
            DSMonHocCua101.Add(new MonHoc(903, "CHUYEN DE WEB", 4, 7.5));

            //ds mon cua 102
            ArrayList DSMonHocCua102 = new ArrayList();
            DSMonHocCua102.Add(new MonHoc(905, "LAP TRINH CO BAN", 3, 9.6));
            DSMonHocCua102.Add(new MonHoc(906, "DO AN CNPM", 4, 8.6));
            DSMonHocCua102.Add(new MonHoc(903, "CHUYEN DE WEB", 4, 7.5));

            //ds mon cua 103
            ArrayList DSMonHocCua103 = new ArrayList();
            DSMonHocCua103.Add(new MonHoc(901, "LAP TRINH .NET", 4, 8.6));
            DSMonHocCua103.Add(new MonHoc(902, "CHUYEN DE JAVA", 4, 9.6));
            DSMonHocCua103.Add(new MonHoc(907, "DO HOA MAY TINH", 4, 7.5));


            DSSinhVien.Add(new SinhVien(101, "TRAN QUANG", "DIEM", "10/6/1999", "NAM", "Thanh Pho Thu Duc", DSMonHocCua101));
            DSSinhVien.Add(new SinhVien(102, "NGUYEN VAN", "A", "11/8/1999", "NAM", "Thanh Pho HCM", DSMonHocCua102));
            DSSinhVien.Add(new SinhVien(103, "LE THI", "C", "20/11/1999", "NU", "Binh Duong", DSMonHocCua103));
        }
        public SinhVien GetSinhVienByTen(string ten)
        {
            SinhVien sv = new SinhVien();
            foreach (SinhVien item in DSSinhVien)
            {
                if (item.Ten.Equals(ten))
                {
                    sv = item;
                }
            }
            return sv;
        }
        public SinhVien GetSinhVienByMaSV(int MaSV)
        {
            SinhVien sv = new SinhVien();
            foreach (SinhVien item in DSSinhVien)
            {
                if (item.MaSV == MaSV)
                {
                    sv = item;
                }
            }
            return sv;
        }
        public ArrayList AddSinhVien(SinhVien sv)
        {
            DSSinhVien.Add(sv);
            return DSSinhVien;
        }
        public void printList()
        {
            foreach(SinhVien sv in DSSinhVien) 
            {
                Console.WriteLine(sv.ToString());
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("====DANH SACH SINH VIEN HIEN CO====");
            Program program = new Program();
            program.init();
            program.printList();
            Console.WriteLine("Co sinh vien co ten DIEM khong ?");
            Console.WriteLine(program.GetSinhVienByTen("DIEM").ToString());

        }
    }

}
