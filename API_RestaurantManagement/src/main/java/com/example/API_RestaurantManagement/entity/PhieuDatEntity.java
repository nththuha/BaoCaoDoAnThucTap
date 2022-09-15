package com.example.API_RestaurantManagement.entity;

import lombok.AllArgsConstructor;
import lombok.Getter;
import lombok.NoArgsConstructor;
import lombok.Setter;

import javax.persistence.*;
import java.util.Date;
import java.util.List;

@Getter
@Setter
@AllArgsConstructor
@NoArgsConstructor
@Entity
@Table(name = "PHIEUDAT")
public class PhieuDatEntity {
    @Id
    @GeneratedValue(strategy = GenerationType.IDENTITY)
    @Column(name = "IDPD")
    private Integer idPD;

    @Column(name = "NGAY")
    @Temporal(TemporalType.DATE)
    private Date ngay;

    @OneToMany(cascade = CascadeType.REFRESH, mappedBy = "idpd")
    private List<CT_DatMonEntity> ctDatmonList;

    @OneToMany(cascade = CascadeType.REFRESH, mappedBy = "idpd")
    private List<CT_DatBanEntity> ctDatbanList;

    @ManyToOne
    @JoinColumn(name = "MAHD")
    private HoaDonEntity mahd;

    @ManyToOne
    @JoinColumn(name = "IDKH")
    private KhachHangEntity idkh;

    @ManyToOne
    @JoinColumn(name = "IDNV")
    private NhanVienEntity idnv;
}
