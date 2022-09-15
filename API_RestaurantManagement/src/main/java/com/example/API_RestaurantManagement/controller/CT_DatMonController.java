package com.example.API_RestaurantManagement.controller;

import com.example.API_RestaurantManagement.dto.CT_DatMonDTO;
import com.example.API_RestaurantManagement.service.CT_DatMonService;
import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.web.bind.annotation.*;

import javax.validation.Valid;
import java.util.List;

@RestController
@RequestMapping("/api/ctdatmon")
@CrossOrigin(origins = "*", maxAge = 3600)
public class CT_DatMonController {
    @Autowired
    private CT_DatMonService ct_datMonService;

    @GetMapping("/{idpd}")
    public List<CT_DatMonDTO> layDSCT_DatMonTheoPhieuDat(@PathVariable Integer idpd) {
        return ct_datMonService.layDSCT_DatMonTheoPhieuDat(idpd);
    }

    @GetMapping("/monan")
    public List<CT_DatMonDTO> layDSCT_DatMon_MonAn() {
        return ct_datMonService.layDSCT_DatMon_MonAn();
    }

    @GetMapping("/nuocuong")
    public List<CT_DatMonDTO> layDSCT_DatMon_NuocUong() {
        return ct_datMonService.layDSCT_DatMon_NuocUong();
    }

    @PostMapping("")
    public CT_DatMonDTO themCT_DatMon(@Valid @RequestBody CT_DatMonDTO ct_datMonDTO) {
        return ct_datMonService.themCT_DatMon(ct_datMonDTO);
    }

    @PutMapping("")
    public CT_DatMonDTO suaCT_DatMon(@Valid @RequestBody CT_DatMonDTO ct_datMonDTO) {
        return ct_datMonService.suaCT_DatMon(ct_datMonDTO);
    }

    @DeleteMapping("/{idCTDM}")
    public String xoaCT_DatMon(@PathVariable Integer idCTDM) {
        return ct_datMonService.xoaCT_DatMon(idCTDM) + "";
    }
}
