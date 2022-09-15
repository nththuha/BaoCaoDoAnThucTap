package com.example.API_RestaurantManagement.controller;

import com.example.API_RestaurantManagement.dto.NhanVienDTO;
import com.example.API_RestaurantManagement.service.NhanVienService;
import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.web.bind.annotation.*;

import javax.validation.Valid;
import java.util.List;

@RestController
@RequestMapping("/api/nhanvien")
@CrossOrigin(origins = "*", maxAge = 3600)
public class NhanVienController {
    @Autowired
    private NhanVienService nhanVienService;

    @GetMapping("")
    public List<NhanVienDTO> layDSNhanVien() {
        return nhanVienService.layDSNhanVien();
    }

    @PostMapping("")
    public NhanVienDTO themNhanVien(@Valid @RequestBody NhanVienDTO nhanVienDTO) {
        return nhanVienService.themNhanVien(nhanVienDTO);
    }

    @PutMapping("")
    public NhanVienDTO suaNhanVien(@Valid @RequestBody NhanVienDTO nhanVienDTO) {
        return nhanVienService.suaNhanVien(nhanVienDTO);
    }

    @DeleteMapping("/{idNV}")
    public String xoaNhanVien(@PathVariable Integer idNV) {
        return nhanVienService.xoaNhanVien(idNV);
    }
}
