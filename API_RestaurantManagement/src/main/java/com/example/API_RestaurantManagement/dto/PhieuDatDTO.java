package com.example.API_RestaurantManagement.dto;

import com.example.API_RestaurantManagement.entity.PhieuDatEntity;
import lombok.AllArgsConstructor;
import lombok.Getter;
import lombok.NoArgsConstructor;
import lombok.Setter;

import java.util.Date;
import java.util.List;
import java.util.stream.Collectors;

@Getter
@Setter
@NoArgsConstructor
@AllArgsConstructor
public class PhieuDatDTO {
    private Integer idPD;

    private Date ngay;

    private List<CT_DatMonDTO> ctDatmonList;

    private List<CT_DatBanDTO> ctDatbanList;

    private String mahd;

    private Integer idkh;

    private String hoTenKH;

    private Integer idnv;

    private String hoTenNV;

    private String maBan;

    private String tenBan;

    private String maPhong;

    private String tenPhong;

    public PhieuDatDTO(PhieuDatEntity phieuDatEntity) {
        this.idPD = phieuDatEntity.getIdPD();
        this.ngay = phieuDatEntity.getNgay();
        if (phieuDatEntity.getMahd() != null) this.mahd = phieuDatEntity.getMahd().getMaHD();
        this.idnv = phieuDatEntity.getIdnv().getIdNV();
        this.hoTenNV = phieuDatEntity.getIdnv().getHoTen();
        if (phieuDatEntity.getIdkh() != null) this.idkh = phieuDatEntity.getIdkh().getIdKH();
        if (phieuDatEntity.getIdkh() != null) this.hoTenKH = phieuDatEntity.getIdkh().getHoTen();
        if (phieuDatEntity.getCtDatbanList() != null)
            this.ctDatbanList = phieuDatEntity.getCtDatbanList().stream().map(CT_DatBanDTO::new).collect(Collectors.toList());
        if (phieuDatEntity.getCtDatmonList() != null)
            this.ctDatmonList = phieuDatEntity.getCtDatmonList().stream().map(CT_DatMonDTO::new).collect(Collectors.toList());
    }

    public PhieuDatEntity toEntity() {
        PhieuDatEntity phieuDatEntity = new PhieuDatEntity();
        phieuDatEntity.setIdPD(this.idPD);
        phieuDatEntity.setNgay(this.ngay);
        return phieuDatEntity;
    }
}
