package com.example.API_RestaurantManagement.dto;

import com.example.API_RestaurantManagement.entity.PhongEntity;
import lombok.AllArgsConstructor;
import lombok.Getter;
import lombok.NoArgsConstructor;
import lombok.Setter;

import java.util.List;
import java.util.stream.Collectors;

@Getter
@Setter
@NoArgsConstructor
@AllArgsConstructor
public class PhongDTO {
    private String maPhong;

    private String tenPhong;

    private String trangThai;

    private List<CT_BanDTO> ctBanList;

    public PhongDTO(PhongEntity phongEntity) {
        this.maPhong = phongEntity.getMaPhong();
        this.tenPhong = phongEntity.getTenPhong();
        if (phongEntity.getCtBanList() != null)
            this.ctBanList = phongEntity.getCtBanList().stream().map(CT_BanDTO::new).collect(Collectors.toList());
    }

    public PhongEntity toEntity() {
        PhongEntity phongEntity = new PhongEntity();
        phongEntity.setMaPhong(this.maPhong);
        phongEntity.setTenPhong(this.tenPhong);
        return phongEntity;
    }
}
