package com.example.API_RestaurantManagement.controller;

import com.example.API_RestaurantManagement.dto.NhanVienDTO;
import com.example.API_RestaurantManagement.dto.TaiKhoanDTO;
import com.example.API_RestaurantManagement.service.TaiKhoanService;
import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.web.bind.annotation.*;

import javax.validation.Valid;
import java.util.List;

@RestController
@RequestMapping("/api/taikhoan")
@CrossOrigin(origins = "*", maxAge = 3600)
public class TaiKhoanController {
    @Autowired
    private TaiKhoanService taiKhoanService;

    @GetMapping("")
    public NhanVienDTO kiemTraDangNhapGET(@Valid @RequestBody TaiKhoanDTO taiKhoanDTO) {
        NhanVienDTO nhanVienDTO = taiKhoanService.kiemTraDangNhap(taiKhoanDTO);
        return nhanVienDTO;
    }

    @PostMapping("")
    public NhanVienDTO kiemTraDangNhap(@Valid @RequestBody TaiKhoanDTO taiKhoanDTO) {
        NhanVienDTO nhanVienDTO = taiKhoanService.kiemTraDangNhap(taiKhoanDTO);
        return nhanVienDTO;
    }

    @GetMapping("/danhsach")
    public List<TaiKhoanDTO> layDSTaiKhoan() {
        return taiKhoanService.layDSTaiKhoan();
    }

    @GetMapping("/{idnv}")
    public TaiKhoanDTO layTaiKhoanTheoIDNV(@PathVariable Integer idnv) {
        return taiKhoanService.layTaiKhoanTheoIDNV(idnv);
    }

    @PostMapping("/them")
    public TaiKhoanDTO themTaiKhoan(@Valid @RequestBody TaiKhoanDTO taiKhoanDTO) {
        return taiKhoanService.themTaiKhoan(taiKhoanDTO);
    }

    @PutMapping("/sua")
    public TaiKhoanDTO suaTaiKhoan(@Valid @RequestBody TaiKhoanDTO taiKhoanDTO) {
        return taiKhoanService.suaTaiKhoan(taiKhoanDTO);
    }
}
