package com.example.API_RestaurantManagement.service.Impl;

import com.example.API_RestaurantManagement.dto.NhanVienDTO;
import com.example.API_RestaurantManagement.entity.BoPhanEntity;
import com.example.API_RestaurantManagement.entity.NhanVienEntity;
import com.example.API_RestaurantManagement.entity.TaiKhoanEntity;
import com.example.API_RestaurantManagement.repository.BoPhanRepository;
import com.example.API_RestaurantManagement.repository.NhanVienRepository;
import com.example.API_RestaurantManagement.repository.TaiKhoanRepository;
import com.example.API_RestaurantManagement.service.NhanVienService;
import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.stereotype.Service;

import java.util.List;
import java.util.stream.Collectors;

@Service
public class NhanVienServiceImpl implements NhanVienService {
    @Autowired
    private NhanVienRepository nhanVienRepository;

    @Autowired
    private BoPhanRepository boPhanRepository;

    @Autowired
    private TaiKhoanRepository taiKhoanRepository;

    @Override
    public List<NhanVienDTO> layDSNhanVien() {
        List<NhanVienEntity> ds = nhanVienRepository.findAll();
        return ds.stream().map(NhanVienDTO::new).collect(Collectors.toList());
    }

    @Override
    public NhanVienDTO themNhanVien(NhanVienDTO nhanVienDTO) {
        BoPhanEntity boPhanEntity = boPhanRepository.getById(nhanVienDTO.getMaBP());
        NhanVienEntity temp = nhanVienDTO.toEntity();
        temp.setMapb(boPhanEntity);
        NhanVienEntity saveNV = nhanVienRepository.save(temp);
        return new NhanVienDTO(saveNV);
    }

    @Override
    public NhanVienDTO suaNhanVien(NhanVienDTO nhanVienDTO) {
        BoPhanEntity boPhanEntity = boPhanRepository.getById(nhanVienDTO.getMaBP());
        TaiKhoanEntity taiKhoanEntity = null;
        if (nhanVienDTO.getTaiKhoan() != null) {
            taiKhoanEntity = taiKhoanRepository.getById(nhanVienDTO.getTaiKhoan());
        }
        NhanVienEntity temp = nhanVienRepository.getById(nhanVienDTO.getIdNV());
        temp.setHoTen(nhanVienDTO.getHoTen());
        temp.setEmail(nhanVienDTO.getEmail());
        temp.setDiaChi(nhanVienDTO.getDiaChi());
        temp.setSDT(nhanVienDTO.getSDT());
        temp.setTaikhoan(taiKhoanEntity);
        temp.setMapb(boPhanEntity);
        NhanVienEntity saveNV = nhanVienRepository.save(temp);
        return new NhanVienDTO(saveNV);
    }

    @Override
    public String xoaNhanVien(Integer idNV) {
        try {
            nhanVienRepository.deleteById(idNV);
            return "true";
        } catch (Exception e) {
            return "false";
        }
    }
}
