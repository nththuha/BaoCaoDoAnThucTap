package com.example.API_RestaurantManagement.controller;

import com.example.API_RestaurantManagement.dto.PhongDTO;
import com.example.API_RestaurantManagement.service.PhongService;
import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.web.bind.annotation.*;

import javax.validation.Valid;
import java.util.List;

@RestController
@RequestMapping("/api/phong")
@CrossOrigin(origins = "*", maxAge = 3600)
public class PhongController {
    @Autowired
    private PhongService phongService;

    @GetMapping("")
    public List<PhongDTO> layDSPhong() {
        return phongService.layDSPhong();
    }

    @PostMapping("")
    public PhongDTO themPhong(@Valid @RequestBody PhongDTO phongDTO) {
        return phongService.themPhong(phongDTO);
    }

    @PutMapping("")
    public PhongDTO suaPhong(@Valid @RequestBody PhongDTO phongDTO) {
        return phongService.suaPhong(phongDTO);
    }

    @DeleteMapping("/{maPhong}")
    public String xoaPhong(@PathVariable String maPhong) {
        return phongService.xoaPhong(maPhong);
    }
}
