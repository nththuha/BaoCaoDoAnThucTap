package com.example.API_RestaurantManagement.controller;

import com.example.API_RestaurantManagement.dto.LoaiMonAnDTO;
import com.example.API_RestaurantManagement.dto.MonAnDTO;
import com.example.API_RestaurantManagement.dto.ThayDoiGiaMonDTO;
import com.example.API_RestaurantManagement.service.LoaiMonAnService;
import com.example.API_RestaurantManagement.service.ThayDoiGiaMonService;
import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.web.bind.annotation.*;

import javax.validation.Valid;
import java.util.ArrayList;
import java.util.List;

@RestController
@RequestMapping("/api/loaimonan")
@CrossOrigin(origins = "*", maxAge = 3600)
public class LoaiMonAnController {
    @Autowired
    private LoaiMonAnService loaiMonAnService;

    @Autowired
    private ThayDoiGiaMonService thayDoiGiaMonService;

    @GetMapping("") // lấy danh sách loại món ăn
    public List<LoaiMonAnDTO> layDSLoaiMonAn() {
        return loaiMonAnService.layDSLoaiMonAn();
    }

    @GetMapping("/{maLMA}")
    public List<MonAnDTO> layDSMonAnTheoLoaiMonAn(@PathVariable String maLMA) {
        List<MonAnDTO> ds = loaiMonAnService.layDSMonAnTheoLoaiMonAn(maLMA);
        List<ThayDoiGiaMonDTO> giaMon = new ArrayList<>();
        for (int i = 0; i < ds.size(); i++) {
            int gia = thayDoiGiaMonService.layGiaHienTai(ds.get(i).getMaMA());
            ds.get(i).setGia(gia);
        }
        return ds;
    }

    @PostMapping("")
    public LoaiMonAnDTO themLoaiMonAn(@Valid @RequestBody LoaiMonAnDTO loaiMonAnDTO) {
        return loaiMonAnService.themLoaiMonAn(loaiMonAnDTO);
    }

    @PutMapping("")
    public LoaiMonAnDTO suaLoaiMonAn(@Valid @RequestBody LoaiMonAnDTO loaiMonAnDTO) {
        return loaiMonAnService.suaLoaiMonAn(loaiMonAnDTO);
    }

    @DeleteMapping("/{maLMA}")
    public String xoaLoaiMonAn(@PathVariable String maLMA) {
        return loaiMonAnService.xoaLoaiMonAn(maLMA) + "";
    }
}
