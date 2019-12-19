﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using DTO;
using DAO;

namespace BUS
{
   public class TaiKhoanBUS
    {
        public static DataTable LayDSTaiKhoan()
        {
            return TaiKhoanDAO.LayDSTaiKhoan();
        }
        public static List<TaiKhoanDTO> LayDSSanPham(string maLoaiSP)
        {
            return TaiKhoanDAO.LayDSTaiKhoanX(maLoaiSP);
        }
        public static TaiKhoanDTO LayThongTinTaiKhoan(string tenTK)
        {
            if (!TaiKhoanDAO.KTTKTonTai(tenTK))
            {
                return null;
            }
            else
            {
                return TaiKhoanDAO.LayThongTinTaiKhoan(tenTK);
            }
        }

        public static bool KTDangNhap(string tenTK, string mk)
        {
            if (!TaiKhoanDAO.KTTKTonTai(tenTK))
            {
                return false;
            }
            else
            {
                return mk == TaiKhoanDAO.LayMatKhau(tenTK);
            }
        }

        public static bool ThemTK(TaiKhoanDTO tk)
        {
            if (TaiKhoanDAO.KTTKTonTai(tk.TenTaiKhoan))
            {
                return false;
            }
            else
            {
                return TaiKhoanDAO.ThemTK(tk);
            }
        }

        public static bool SuaTK(TaiKhoanDTO tk)
        {
            if (!TaiKhoanDAO.KTTKTonTai(tk.TenTaiKhoan))
            {
                return false;
            }
            else
            {
                return TaiKhoanDAO.SuaTK(tk);
            }
        }

        public static bool XoaTK(string tenTK)
        {
            if (!TaiKhoanDAO.KTTKTonTai(tenTK))
            {
                return false;
            }
            else
            {
                return TaiKhoanDAO.XoaTK(tenTK);
            }
        }
    }
}
