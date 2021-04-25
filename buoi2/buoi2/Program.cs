using System;
using System.Collections;
using System.Diagnostics.CodeAnalysis;
using System.Text;

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
        public ArrayList DSMonHoc { set; get; }

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
            Console.OutputEncoding = Encoding.Unicode;
            return "Sinh vien: " + MaSV + ", ho va ten = " + HoLot + " " + Ten + ", ngay sinh = " + NgaySinh + ", gioi tinh = " + GioiTinh + ", dia chi = " + DiaChi+"\nDSMH: "+printDSMH(DSMonHoc);

        }

        public string printDSMH(ArrayList DSMH)
        {
            Console.OutputEncoding = Encoding.Unicode;
            StringBuilder sb = new StringBuilder();
            foreach(MonHoc mh in DSMH)
            {
                sb.Append(mh.ToString() + "\n");
            }
            return sb.ToString();
        }

        public int CompareTo([AllowNull] SinhVien other)
        {
            return this.Ten.CompareTo(other.Ten);
        }
    }
    class MonHoc
    {
        public int MaMH { set; get; }
        public string TenMH { set; get; }
        public int SoTC { set; get; }
        public double Diem { set; get; }

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

        public override string ToString()
        {
            Console.OutputEncoding = Encoding.Unicode;
            return "MON HOC {" + MaMH + ", " + TenMH + ", " + SoTC + ", " + Diem+"}";
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

        public void run()
        {
            Console.OutputEncoding = Encoding.Unicode;
            int action = 0;
            do
            {
                Console.WriteLine("=======MENU=======\n1. Thêm sinh viên\n2. Xóa sinh viên theo mã\n3. Sửa sinh viên theo mã\n4. Tìm kiếm sinh viên theo mã\n5. Sắp xếp tăng dần theo điểm trung bình\n6. Hiển thị danh sách\n7. Thoát chương trình");
                String choosen = Console.ReadLine();
                try
                {
                    action = int.Parse(choosen);

                    switch (action)
                    {
                        case 1:
                            SinhVien sv = new SinhVien();
                            Console.WriteLine("Nhập thông tin sinh viên\n1. Họ lót:");
                            sv.HoLot = Console.ReadLine();
                            Console.WriteLine("2. Tên:");
                            sv.Ten = Console.ReadLine();
                            Console.WriteLine("3. Ngày tháng năm sinh (dd/mm/yyyy):");
                            sv.NgaySinh = Console.ReadLine();
                            Console.WriteLine("4. Giới tính:");
                            sv.GioiTinh = Console.ReadLine();
                            Console.WriteLine("5. Địa chỉ:");
                            sv.DiaChi = Console.ReadLine();
                            Console.WriteLine("6. Danh sách môn học\n6.1 Mã môn học:");
                            ArrayList dsMH = new ArrayList();
                            MonHoc mh = new MonHoc();
                            mh.MaMH = int.Parse(Console.ReadLine());
                            Console.WriteLine("6.2 Tên môn học:");
                            mh.TenMH = Console.ReadLine();
                            Console.WriteLine("6.3 Số tín chỉ:");
                            mh.SoTC = int.Parse(Console.ReadLine());
                            Console.WriteLine("6.4 Điểm trung bình:");
                            mh.Diem = double.Parse(Console.ReadLine());

                            dsMH.Add(mh);
                            sv.DSMonHoc = dsMH;
                            AddSinhVien(sv);
                            Console.WriteLine("Đã thêm thành công sinh viên!");
                            break;
                        case 2:
                            break;
                        case 3:
                            break;
                        case 4:
                            break;
                        case 5:
                            break;
                        case 6:
                            if (DSSinhVien.Count == 0)
                            {
                                Console.WriteLine("DANH SÁCH SINH VIÊN HIỆN ĐANG TRỐNG!");
                            }
                            else
                            {
                                Console.WriteLine("DANH SÁCH SINH VIÊN");
                                printList();
                            }
                            break;
                        case 7:
                            Console.WriteLine("Thoát chương trình thành công!");
                            break;
                    }
                }
                catch (FormatException)
                {
                    Console.WriteLine("Yêu cầu chức năng không đúng! Vui lòng chọn số theo chức năng!");
                }
            } while (action != 7);

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
          
            Program program = new Program();
            program.run();
            //program.init();
            //program.printList();
            //Console.WriteLine("Co sinh vien co ten DIEM khong ?");
            //Console.WriteLine(program.GetSinhVienByTen("DIEM").ToString());

        }
    }

}
