package com.example.API_RestaurantManagement.controller;

import com.example.API_RestaurantManagement.dto.BanDTO;
import com.example.API_RestaurantManagement.service.BanService;
import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.web.bind.annotation.*;

import javax.validation.Valid;
import java.util.List;


@RestController
@RequestMapping("/api/ban")
@CrossOrigin(origins = "*", maxAge = 3600)
public class BanController {
    @Autowired
    private BanService banService;

    @GetMapping("")
    public List<BanDTO> layDSBan() {
        return banService.layDSBan();
    }

    @PostMapping("")
    public BanDTO themBan(@Valid @RequestBody BanDTO banDTO) {
        return banService.themBan(banDTO);
    }

    @PutMapping("")
    public BanDTO suaBan(@Valid @RequestBody BanDTO banDTO) {
        return banService.suaBan(banDTO);
    }

    @DeleteMapping("/{maBan}")
    public String xoaBan(@PathVariable String maBan) {
        return banService.xoaBan(maBan);
    }
}
