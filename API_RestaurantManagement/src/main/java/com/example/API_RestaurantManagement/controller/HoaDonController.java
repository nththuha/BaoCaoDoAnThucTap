package com.example.API_RestaurantManagement.controller;

import com.example.API_RestaurantManagement.dto.HDDTO;
import com.example.API_RestaurantManagement.dto.HoaDonDTO;
import com.example.API_RestaurantManagement.service.HoaDonService;
import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.web.bind.annotation.*;

import javax.validation.Valid;

@RestController
@RequestMapping("/api/hoadon")
@CrossOrigin(origins = "*", maxAge = 3600)
public class HoaDonController {
    @Autowired
    private HoaDonService hoaDonService;

    @PostMapping("")
    public HDDTO themHoaDon(@Valid @RequestBody HoaDonDTO hoaDonDTO) {
        return hoaDonService.themHoaDon(hoaDonDTO);
    }
}
