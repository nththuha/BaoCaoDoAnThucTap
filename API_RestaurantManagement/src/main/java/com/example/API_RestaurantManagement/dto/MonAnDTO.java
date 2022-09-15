package com.example.API_RestaurantManagement.dto;

import com.example.API_RestaurantManagement.entity.MonAnEntity;
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
public class MonAnDTO {
    private String maMA;

    private String tenMA;

    private String chuThich;

    private String trangThai;

    private String hinhAnh;

    private int gia;

    private List<CT_DatMonDTO> ctDatmonList;

    //    private List<CT_MonAnDTO> ctMonanList;
//
    private List<ThayDoiGiaMonDTO> thaydoigiamonList;

    private String malma;

    private String tenlma;

    public MonAnDTO(MonAnEntity monAnEntity) {
        this.maMA = monAnEntity.getMaMA();
        this.tenMA = monAnEntity.getTenMA();
        this.chuThich = monAnEntity.getChuThich();
        this.hinhAnh = monAnEntity.getHinhAnh();
        this.trangThai = monAnEntity.getTrangThai();
        this.malma = monAnEntity.getMalma().getMaLMA();
        this.tenlma = monAnEntity.getMalma().getTenLMA();
        if (monAnEntity.getCtDatmonList() != null)
            this.ctDatmonList = monAnEntity.getCtDatmonList().stream().map(CT_DatMonDTO::new).collect(Collectors.toList());
        if (monAnEntity.getThaydoigiamonList() != null)
            this.thaydoigiamonList = monAnEntity.getThaydoigiamonList().stream().map(ThayDoiGiaMonDTO::new).collect(Collectors.toList());
    }

    public MonAnEntity toEntity() {
        MonAnEntity monAnEntity = new MonAnEntity();
        monAnEntity.setMaMA(this.maMA);
        monAnEntity.setTenMA(this.tenMA);
        monAnEntity.setHinhAnh(this.hinhAnh);
        monAnEntity.setChuThich(this.chuThich);
        monAnEntity.setTrangThai(this.trangThai);
        return monAnEntity;
    }
}
