package com.example.API_RestaurantManagement.controller;

import com.example.API_RestaurantManagement.dto.MonAnDTO;
import com.example.API_RestaurantManagement.service.MonAnService;
import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.web.bind.annotation.*;

import javax.validation.Valid;
import java.util.List;

@RestController
@RequestMapping("/api/monan")
@CrossOrigin(origins = "*", maxAge = 3600)
public class MonAnController {
    @Autowired
    private MonAnService monAnService;

    @GetMapping("") // lấy danh sách loại món ăn
    public List<MonAnDTO> layDSMonAn() {
        return monAnService.layDSMonAn();
    }

    @GetMapping("/{maMA}")
    public MonAnDTO suaTrangThaiMonAn(@PathVariable String maMA) {
        return monAnService.suaTrangThaiMonAn(maMA);
    }

    @PostMapping("")
    public MonAnDTO themMonAn(@Valid @RequestBody MonAnDTO monAnDTO) {
        return monAnService.themMonAn(monAnDTO);
    }

    @PutMapping("")
    public MonAnDTO suaMonAn(@Valid @RequestBody MonAnDTO monAnDTO) {
        return monAnService.suaMonAn(monAnDTO);
    }

    @DeleteMapping("/{maMA}")
    public String xoaMonAn(@PathVariable String maMA) {
        return monAnService.xoaMonAn(maMA);
    }
}
