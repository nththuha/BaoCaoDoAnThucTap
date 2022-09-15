package com.example.API_RestaurantManagement.dto;

import com.example.API_RestaurantManagement.entity.NhanVienEntity;
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
public class NhanVienDTO {
    private Integer idNV;

    private String hoTen;

    private String sDT;

    private String diaChi;

    private String email;

//    private List<PhieuNhapNguyenLieuDTO> phieunhapnguyenlieuList;

    private String taiKhoan;

    private List<PhieuDatDTO> phieudatList;

    private List<ThayDoiGiaMonDTO> thaydoigiamonList;

    private String maBP;

    private String tenBP;

    public NhanVienDTO(NhanVienEntity nhanVienEntity) {
        this.idNV = nhanVienEntity.getIdNV();
        this.hoTen = nhanVienEntity.getHoTen();
        this.sDT = nhanVienEntity.getSDT();
        this.diaChi = nhanVienEntity.getDiaChi();
        this.email = nhanVienEntity.getEmail();
        if (nhanVienEntity.getTaikhoan() != null) this.taiKhoan = nhanVienEntity.getTaikhoan().getMaTK();
        this.maBP = nhanVienEntity.getMapb().getMaBP();
        this.tenBP = nhanVienEntity.getMapb().getTenBP();
        if (nhanVienEntity.getPhieudatList() != null)
            this.phieudatList = nhanVienEntity.getPhieudatList().stream().map(PhieuDatDTO::new).collect(Collectors.toList());
        if (nhanVienEntity.getThaydoigiamonList() != null)
            this.thaydoigiamonList = nhanVienEntity.getThaydoigiamonList().stream().map(ThayDoiGiaMonDTO::new).collect(Collectors.toList());
    }

    public NhanVienEntity toEntity() {
        NhanVienEntity nhanVienEntity = new NhanVienEntity();
        nhanVienEntity.setIdNV(this.idNV);
        nhanVienEntity.setHoTen(this.hoTen);
        nhanVienEntity.setSDT(this.sDT);
        nhanVienEntity.setDiaChi(this.diaChi);
        nhanVienEntity.setEmail(this.email);
        return nhanVienEntity;
    }
}
