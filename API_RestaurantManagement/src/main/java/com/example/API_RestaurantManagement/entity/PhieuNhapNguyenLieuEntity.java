package com.example.API_RestaurantManagement.entity;

import lombok.AllArgsConstructor;
import lombok.Getter;
import lombok.NoArgsConstructor;
import lombok.Setter;
import org.springframework.format.annotation.DateTimeFormat;

import javax.persistence.*;
import java.util.Date;
import java.util.List;

@Getter
@Setter
@AllArgsConstructor
@NoArgsConstructor
@Entity
@Table(name = "PHIEUNHAPNGUYENLIEU")
public class PhieuNhapNguyenLieuEntity {
    @Id
    @GeneratedValue(strategy = GenerationType.IDENTITY)
    @Column(name = "IDPN")
    private Integer idPN;

    @Column(name = "NGAY")
    @Temporal(TemporalType.DATE)
    @DateTimeFormat(pattern = "dd/MM/yyyy")
    private Date ngay;

    @ManyToOne
    @JoinColumn(name = "IDNV")
    private NhanVienEntity idnv;

    @OneToMany(cascade = CascadeType.REFRESH, mappedBy = "idpn")
    private List<CTPN_NguyenLieuEntity> ctpnNguyenlieuList;
}
