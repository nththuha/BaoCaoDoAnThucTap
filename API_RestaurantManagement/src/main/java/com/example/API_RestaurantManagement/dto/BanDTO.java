package com.example.API_RestaurantManagement.dto;

import com.example.API_RestaurantManagement.entity.BanEntity;
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
public class BanDTO {
    private String maBan;

    private String tenBan;

    private String trangThai;

    private Integer soGhe;

    private List<CT_BanDTO> ctBanList;

    public BanDTO(BanEntity banEntity) {
        this.maBan = banEntity.getMaBan();
        this.tenBan = banEntity.getTenBan();
        this.soGhe = banEntity.getSoGhe();
        if (banEntity.getCtBanList() != null)
            this.ctBanList = banEntity.getCtBanList().stream().map(CT_BanDTO::new).collect(Collectors.toList());
    }

    public BanEntity toEntity() {
        BanEntity banEntity = new BanEntity();
        banEntity.setSoGhe(this.soGhe);
        banEntity.setMaBan(this.maBan);
        banEntity.setTenBan(this.tenBan);
        return banEntity;
    }
}
