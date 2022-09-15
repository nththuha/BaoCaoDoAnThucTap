package com.example.API_RestaurantManagement.service.Impl;

import com.example.API_RestaurantManagement.dto.ThayDoiGiaMonDTO;
import com.example.API_RestaurantManagement.entity.MonAnEntity;
import com.example.API_RestaurantManagement.entity.NhanVienEntity;
import com.example.API_RestaurantManagement.entity.ThayDoiGiaMonEntity;
import com.example.API_RestaurantManagement.repository.MonAnRepository;
import com.example.API_RestaurantManagement.repository.NhanVienRepository;
import com.example.API_RestaurantManagement.repository.ThayDoiGiaMonRepository;
import com.example.API_RestaurantManagement.service.ThayDoiGiaMonService;
import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.stereotype.Service;

import java.text.DateFormat;
import java.text.SimpleDateFormat;
import java.util.Date;
import java.util.List;
import java.util.stream.Collectors;

@Service
public class ThayDoiGiaMonServiceImpl implements ThayDoiGiaMonService {
    @Autowired
    private ThayDoiGiaMonRepository thayDoiGiaMonRepository;

    @Autowired
    private MonAnRepository monAnRepository;

    @Autowired
    private NhanVienRepository nhanVienRepository;

    @Override
    public List<ThayDoiGiaMonDTO> layDSGiaMon(String maMA) {
        List<ThayDoiGiaMonEntity> thayDoiGiaMonEntity = thayDoiGiaMonRepository.findByMama_MaMAOrderByNgayDesc(maMA);
        return thayDoiGiaMonEntity.stream().map(ThayDoiGiaMonDTO::new).collect(Collectors.toList());
    }

    public int layGiaHienTai(String maMA) {
        List<ThayDoiGiaMonEntity> ds = thayDoiGiaMonRepository.findByMama_MaMAOrderByNgayDesc(maMA);
        DateFormat simpleDateFormat = new SimpleDateFormat("yyyy-MM-dd");
        Date currentDate = new Date();
        String now = simpleDateFormat.format(currentDate);
        Date hienTai = new Date();
        try {
            hienTai = simpleDateFormat.parse(now);
        } catch (Exception e) {
            System.out.println(e.toString());
        }
        long min = 100000000;
        int vt = 0;
        for (int i = 0; i < ds.size(); i++) {
            long getDiff = hienTai.getTime() - ds.get(i).getNgay().getTime();
            long getDaysDiff = getDiff / (24 * 60 * 60 * 1000);
            if (getDaysDiff >= 0 && getDaysDiff < min) {
                min = getDaysDiff;
                vt = i;
            }
        }
        if (ds.size() > 0) return ds.get(vt).getGia();
        return 0;
    }

    @Override
    public ThayDoiGiaMonDTO suaGiaMon(ThayDoiGiaMonDTO thayDoiGiaMonDTO) {
        MonAnEntity monAnEntity = monAnRepository.getById(thayDoiGiaMonDTO.getMama());
        NhanVienEntity nhanVienEntity = nhanVienRepository.getById(thayDoiGiaMonDTO.getIdnv());
        ThayDoiGiaMonEntity giaMon = thayDoiGiaMonRepository.getById(thayDoiGiaMonDTO.getIdGM());
        giaMon.setGia(thayDoiGiaMonDTO.getGia());
        giaMon.setNgay(thayDoiGiaMonDTO.getNgay());
        giaMon.setMama(monAnEntity);
        giaMon.setIdnv(nhanVienEntity);
        ThayDoiGiaMonEntity temp = thayDoiGiaMonRepository.save(giaMon);
        return new ThayDoiGiaMonDTO(temp);
    }

    @Override
    public String xoaGiaMon(Integer idGM) {
        try {
            thayDoiGiaMonRepository.deleteById(idGM);
            return true + "";
        } catch (Exception e) {
            return false + "";
        }
    }

    @Override
    public ThayDoiGiaMonDTO themGiaMon(ThayDoiGiaMonDTO thayDoiGiaMonDTO) {
        MonAnEntity monAnEntity = monAnRepository.getById(thayDoiGiaMonDTO.getMama());
        NhanVienEntity nhanVienEntity = nhanVienRepository.getById(thayDoiGiaMonDTO.getIdnv());
        ThayDoiGiaMonEntity temp = thayDoiGiaMonDTO.toEntity();
        temp.setIdnv(nhanVienEntity);
        temp.setMama(monAnEntity);
        ThayDoiGiaMonEntity saveTDGM = thayDoiGiaMonRepository.save(temp);
        return new ThayDoiGiaMonDTO(saveTDGM);
    }
}
