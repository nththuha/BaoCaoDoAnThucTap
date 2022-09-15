package com.example.API_RestaurantManagement.controller;

import com.example.API_RestaurantManagement.dto.KhachHangDTO;
import com.example.API_RestaurantManagement.service.KhachHangService;
import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.web.bind.annotation.*;

import javax.validation.Valid;
import java.util.List;

@RestController
@RequestMapping("/api/khachhang")
@CrossOrigin(origins = "*", maxAge = 3600)
public class KhachHangController {
    @Autowired
    private KhachHangService khachHangService;

    @GetMapping("")
    public List<KhachHangDTO> layDSKhachHang() {
        return khachHangService.layDSKhachHang();
    }

    @PostMapping("")
    public KhachHangDTO themKhachHang(@Valid @RequestBody KhachHangDTO khachHangDTO) {
        return khachHangService.themKhachHang(khachHangDTO);
    }
}
