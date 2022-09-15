package com.example.API_RestaurantManagement.entity;

import lombok.AllArgsConstructor;
import lombok.Getter;
import lombok.NoArgsConstructor;
import lombok.Setter;

import javax.persistence.*;
import javax.validation.constraints.Size;
import java.util.List;

@Getter
@Setter
@AllArgsConstructor
@NoArgsConstructor
@Entity
@Table(name = "NHANVIEN")
public class NhanVienEntity {
    @Id
    @GeneratedValue(strategy = GenerationType.IDENTITY)
    @Column(name = "IDNV")
    private Integer idNV;

    @Column(name = "HOTEN")
    @Size(max = 50)
    private String hoTen;

    @Column(name = "SDT")
    @Size(max = 50)
    private String sDT;

    @Column(name = "DIACHI")
    @Size(max = 50)
    private String diaChi;

    @Column(name = "EMAIL")
    @Size(max = 50)
    private String email;

    @OneToMany(cascade = CascadeType.REFRESH, mappedBy = "idnv")
    private List<PhieuNhapNguyenLieuEntity> phieunhapnguyenlieuList;

    @OneToOne(cascade = CascadeType.REFRESH, mappedBy = "idnv")
    private TaiKhoanEntity taikhoan;

    @OneToMany(cascade = CascadeType.REFRESH, mappedBy = "idnv")
    private List<PhieuDatEntity> phieudatList;

    @OneToMany(cascade = CascadeType.REFRESH, mappedBy = "idnv")
    private List<ThayDoiGiaMonEntity> thaydoigiamonList;

    @ManyToOne
    @JoinColumn(name = "MAPB")
    private BoPhanEntity mapb;

    @OneToMany(cascade = CascadeType.REFRESH, mappedBy = "idnv")
    private List<HoaDonEntity> hoadonList;
}
