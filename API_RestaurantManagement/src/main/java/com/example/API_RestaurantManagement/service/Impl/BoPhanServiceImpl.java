package com.example.API_RestaurantManagement.service.Impl;

import com.example.API_RestaurantManagement.dto.BoPhanDTO;
import com.example.API_RestaurantManagement.entity.BoPhanEntity;
import com.example.API_RestaurantManagement.repository.BoPhanRepository;
import com.example.API_RestaurantManagement.service.BoPhanService;
import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.stereotype.Service;

import java.util.List;
import java.util.stream.Collectors;

@Service
public class BoPhanServiceImpl implements BoPhanService {
    @Autowired
    private BoPhanRepository boPhanRepository;

    @Override
    public List<BoPhanDTO> layDSBoPhan() {
        List<BoPhanEntity> ds = boPhanRepository.findAll();
        return ds.stream().map(BoPhanDTO::new).collect(Collectors.toList());
    }
}
