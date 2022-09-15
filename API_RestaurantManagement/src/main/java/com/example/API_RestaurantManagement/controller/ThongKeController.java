package com.example.API_RestaurantManagement.controller;

import com.example.API_RestaurantManagement.dto.ThongKeDTO;
import com.example.API_RestaurantManagement.service.ThongKeService;
import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.web.bind.annotation.*;

import javax.validation.Valid;
import java.util.List;

@RestController
@RequestMapping("/api/thongke")
@CrossOrigin(origins = "*", maxAge = 3600)
public class ThongKeController {
    @Autowired
    private ThongKeService thongKeService;

    @PostMapping("")
    public List<ThongKeDTO> thongKe(@Valid @RequestBody ThongKeDTO thongKeDTO) {
        return thongKeService.thongKe(thongKeDTO);
    }
}
