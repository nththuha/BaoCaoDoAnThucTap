package com.example.API_RestaurantManagement.controller;

import com.example.API_RestaurantManagement.dto.ThayDoiGiaMonDTO;
import com.example.API_RestaurantManagement.service.ThayDoiGiaMonService;
import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.web.bind.annotation.*;

import javax.validation.Valid;
import java.util.List;

@RestController
@RequestMapping("/api/thaydoigiamon")
@CrossOrigin(origins = "*", maxAge = 3600)
public class ThayDoiGiaMonController {
    @Autowired
    private ThayDoiGiaMonService thayDoiGiaMonService;

    @GetMapping("/{mama}")
    public List<ThayDoiGiaMonDTO> layDSGiaTheoMon(@PathVariable String mama) {
        return thayDoiGiaMonService.layDSGiaMon(mama);
    }

    @PutMapping("")
    public ThayDoiGiaMonDTO suaGiaMon(@Valid @RequestBody ThayDoiGiaMonDTO thayDoiGiaMonDTO) {
        return thayDoiGiaMonService.suaGiaMon(thayDoiGiaMonDTO);
    }

    @PostMapping("")
    public ThayDoiGiaMonDTO themGiaMon(@Valid @RequestBody ThayDoiGiaMonDTO thayDoiGiaMonDTO) {
        return thayDoiGiaMonService.themGiaMon(thayDoiGiaMonDTO);
    }

    @DeleteMapping("/{idGM}")
    public String xoaGiaMon(@PathVariable Integer idGM) {
        return thayDoiGiaMonService.xoaGiaMon(idGM);
    }
}
