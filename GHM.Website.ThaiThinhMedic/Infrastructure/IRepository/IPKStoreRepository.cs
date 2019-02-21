﻿using GHM.Website.ThaiThinhMedic.Infrastructure.ViewModels;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace GHM.Website.ThaiThinhMedic.Api.Infrastructure.IRepository
{
    public interface IPKStoreRepository
    {
        int DmBacSyInsert(string maBacSy, string hoTen, string maKhoa, string noiCongTac, string dienThoai, string diaChi, string chuyenNganh, string bangCapChuyenMon, string quaTrinhCongTac, int? keDon, bool? hienSoDienThoai, bool? dung, string col1, string col2, string col3, string col4, string col5, string ghiChu, bool? khamDoan, string queQuan, DateTime? ngayBatDauLamViec, string chuyenMonSau, string danhGiaCuaKhachHang, byte[] anh, string maHocHam, string maHocVi, DateTime? ngaySinh, string maChucDanh, string maChucVu, int? soCaSangKm, int? soCaChieuKm, int? soCaToiKm);
        int DmBacSyUpdate(string maBacSy, string hoTen, string maKhoa, string noiCongTac, string dienThoai, string diaChi, string chuyenNganh, string bangCapChuyenMon, string quaTrinhCongTac, int? keDon, bool? hienSoDienThoai, bool? dung, string col1, string col2, string col3, string col4, string col5, string ghiChu, bool? khamDoan, string queQuan, DateTime? ngayBatDauLamViec, string chuyenMonSau, string danhGiaCuaKhachHang, byte[] anh, string maHocHam, string maHocVi, DateTime? ngaySinh, string maChucDanh, string maChucVu, int? soCaSangKm, int? soCaChieuKm, int? soCaToiKm);
        int DmyTaInsert(string maYTa, string hoTen, string maKhoa, bool? dung, string ghiChu, string chuyenNganh, string bangCapChuyenMon, string quaTrinhCongTac, string maChucDanh, string maChucVu);
        int DmyTaUpdate(string maYTa, string hoTen, string maKhoa, bool? dung, string ghiChu, string chuyenNganh, string bangCapChuyenMon, string quaTrinhCongTac, string maChucDanh, string maChucVu);
        int DsNhanVienInsert(string maNhanVien, string hoTenNhanVien, bool? maGioiTinh, DateTime? ngaySinh, string noiSinh, string thuongTru, string tamTru, string maDanToc, string soCmnd, string noiCap, DateTime? ngayCapCmnd, string ghiChu, DateTime? ngayVaoCoQuan, string maChucDanh, string maChucVu, string maPhongBan, string dienThoai, string email, string maThamChieu, string diaChiLienHe, string chuyenMon, string maSoBhyt, string soSoBhyt, DateTime? ngayCapBh, string soTknh, string nganHang, string maSoThueTncn, bool? dung, int? idLoaiNhanVien, bool? tamNghi, DateTime? ngayApDungTamNghi, string tenTiengAnh, string diaChiThuongTru, string diaChiTamTru, bool? dangLamViec, bool? nghiKhongLuong, bool? nghiThaiSan, bool? nghiViec, byte[] anh, string col1, string col2, string queQuan, string chuyenKhoa, string cacChungChiChuyenKhoa, string chuyenMonSau, string danhGiaCuaKhachHang, string maHocHam, string maHocVi, DateTime? ngayNghiViec, string lyDoNghiViec, string maTonGiao, string maQuocGia, int? tinhTrangHonNhan, int? soCon, string emailCaNhan, string dienThoaiNhaRieng, string dienThoaiCoQuan, string dienThoaiNguoiThan, string maBangCap, string bangCapKhac, int? cchnyTuNhan, string soCchn, DateTime? ngayCapCchn, string noiCapCchn, int? thoiGianHdld, int? hopDongLaoDong, int? hinhThucLamViec, int? soNgayLamViecTrongTuan, string thoiGianLamViecSang, string thoiGianLamViecChieu, string thoiGianLamViecToi, int? soNgayNghiPhepTrongNam, int? col3, int? col4, string col5, string col6, string col7, string col8, string col9, string soHoChieu, string noiCapHoChieu, DateTime? ngayCapHoChieu, DateTime? ngayCbhhhd);
        int DsNhanVienUpdate(string maNhanVien, string hoTenNhanVien, bool? maGioiTinh, DateTime? ngaySinh, string noiSinh, string thuongTru, string tamTru, string maDanToc, string soCmnd, string noiCap, DateTime? ngayCapCmnd, string ghiChu, DateTime? ngayVaoCoQuan, string maChucDanh, string maChucVu, string maPhongBan, string dienThoai, string email, string maThamChieu, string diaChiLienHe, string chuyenMon, string maSoBhyt, string soSoBhyt, DateTime? ngayCapBh, string soTknh, string nganHang, string maSoThueTncn, bool? dung, int? idLoaiNhanVien, bool? tamNghi, DateTime? ngayApDungTamNghi, string tenTiengAnh, string diaChiThuongTru, string diaChiTamTru, bool? dangLamViec, bool? nghiKhongLuong, bool? nghiThaiSan, bool? nghiViec, byte[] anh, string col1, string col2, string queQuan, string chuyenKhoa, string cacChungChiChuyenKhoa, string chuyenMonSau, string danhGiaCuaKhachHang, string maHocHam, string maHocVi, DateTime? ngayNghiViec, string lyDoNghiViec, string maTonGiao, string maQuocGia, int? tinhTrangHonNhan, int? soCon, string emailCaNhan, string dienThoaiNhaRieng, string dienThoaiCoQuan, string dienThoaiNguoiThan, string maBangCap, string bangCapKhac, int? cchnyTuNhan, string soCchn, DateTime? ngayCapCchn, string noiCapCchn, int? thoiGianHdld, int? hopDongLaoDong, int? hinhThucLamViec, int? soNgayLamViecTrongTuan, string thoiGianLamViecSang, string thoiGianLamViecChieu, string thoiGianLamViecToi, int? soNgayNghiPhepTrongNam, int? col3, int? col4, string col5, string col6, string col7, string col8, string col9, string soHoChieu, string noiCapHoChieu, DateTime? ngayCapHoChieu, DateTime? ngayCbhhhd);
        Task<DmKhoaGetByIdViewModel> DmKhoaGetById(string maKhoa);
        Task<List<DmKhoaSelectAllViewModel>> DmKhoaSelectAll();
        int DsNhanVienUpdateWeb(string maNhanVien, string hoTenNhanVien, bool? maGioiTinh, DateTime? ngaySinh, string soCmnd, string noiCap, DateTime? ngayCapCmnd, DateTime? ngayVaoCoQuan, string dienThoai, string email, string soTknh, string nganHang, string maSoThueTncn, int? soCon, int? officeId, string officeName, string officeIdPath);
        int DsNhanVienInsertWeb(string maNhanVien, string hoTenNhanVien, bool? maGioiTinh, DateTime? ngaySinh, string soCmnd, string noiCap, DateTime? ngayCapCmnd, DateTime? ngayVaoCoQuan, string dienThoai, string email, string soTknh, string nganHang, string maSoThueTncn, int? soCon, int? officeId, string officeName, string officeIdPath);
        int AppointmentScheduleExistsByDatePhoneShiftAndServiceKind(DateTime? startTime, string phoneNumber, string shift, string serviceId);
        int AppointmentScheduleExistsByTimeAndServiceKind(DateTime? startTime, string phoneNumber, string shift, string hour, string maBacSy);
        int UpdateUserPassword(string userId, string password);
        int NguoiDungInsertWeb(string id, string fullName, string userName, string password);
        int DsNhanVienUpdateOfficeIdPath(string xmlOfficeDocument);
    }
}
