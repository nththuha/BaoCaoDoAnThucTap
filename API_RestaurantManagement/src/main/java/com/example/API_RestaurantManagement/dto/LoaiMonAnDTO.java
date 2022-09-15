package com.example.API_RestaurantManagement.dto;

import com.example.API_RestaurantManagement.entity.LoaiMonAnEntity;
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
public class LoaiMonAnDTO {
    private String maLMA;

    private String tenLMA;

    private String hinhAnh;

    private List<MonAnDTO> monanList;

    public LoaiMonAnDTO(LoaiMonAnEntity loaiMonAnEntity) {
        this.maLMA = loaiMonAnEntity.getMaLMA();
        this.tenLMA = loaiMonAnEntity.getTenLMA();
        this.hinhAnh = loaiMonAnEntity.getHinhAnh();
        this.monanList = loaiMonAnEntity.getMonanList().stream().map(MonAnDTO::new).collect(Collectors.toList());
    }

    public LoaiMonAnEntity toEntity() {
        LoaiMonAnEntity loaiMonAnEntity = new LoaiMonAnEntity();
        loaiMonAnEntity.setMaLMA(this.maLMA);
        loaiMonAnEntity.setTenLMA(this.tenLMA);
        loaiMonAnEntity.setHinhAnh(this.hinhAnh);
        return loaiMonAnEntity;
    }
}
