package com.example.API_RestaurantManagement.controller;

import com.example.API_RestaurantManagement.dto.PhieuDatDTO;
import com.example.API_RestaurantManagement.service.PhieuDatService;
import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.web.bind.annotation.*;

import javax.validation.Valid;
import java.util.List;

@RestController
@RequestMapping("/api/phieudat")
@CrossOrigin(origins = "*", maxAge = 3600)
public class PhieuDatController {
    @Autowired
    private PhieuDatService phieuDatService;

    @GetMapping("")
    public List<PhieuDatDTO> layDSPhieuDatChuaCoHoaDon() {
        return phieuDatService.layDSPhieuDatChuaCoHoaDon();
    }

    @PostMapping("")
    public PhieuDatDTO themPhieuDat(@Valid @RequestBody PhieuDatDTO phieuDatDTO) {
        return phieuDatService.themPhieuDat(phieuDatDTO);
    }

    @PutMapping("")
    public PhieuDatDTO suaPhieuDat(@Valid @RequestBody PhieuDatDTO phieuDatDTO) {
        return phieuDatService.suaPhieuDat(phieuDatDTO);
    }
}
