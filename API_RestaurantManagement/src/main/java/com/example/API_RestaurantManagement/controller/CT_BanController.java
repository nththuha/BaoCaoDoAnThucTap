package com.example.API_RestaurantManagement.controller;

import com.example.API_RestaurantManagement.dto.BanDTO;
import com.example.API_RestaurantManagement.dto.CT_BanDTO;
import com.example.API_RestaurantManagement.service.CT_BanService;
import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.web.bind.annotation.*;

import javax.validation.Valid;
import java.util.List;

@RestController
@RequestMapping("/api/ctban")
@CrossOrigin(origins = "*", maxAge = 3600)
public class CT_BanController {
    @Autowired
    private CT_BanService ct_banService;

    @GetMapping("/{maphong}")
    public List<BanDTO> layDSBanTheoPhong(@PathVariable String maphong) {
        return ct_banService.layDSBanTheoPhong(maphong);
    }

    @GetMapping("/danhsach/{maphong}")
    public List<CT_BanDTO> layDSCTBanTheoPhong(@PathVariable String maphong) {
        return ct_banService.layDSCTBanTheoPhong(maphong);
    }

    @PostMapping("")
    public String themCTBan(@Valid @RequestBody CT_BanDTO ct_banDTO) {
        return ct_banService.themCTBan(ct_banDTO);
    }

    @DeleteMapping("/{idCTB}")
    public String xoaCTBan(@PathVariable Integer idCTB) {
        return ct_banService.xoaCTBan(idCTB);
    }
}
