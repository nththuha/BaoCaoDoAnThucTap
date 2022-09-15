package com.example.API_RestaurantManagement.entity;

import lombok.AllArgsConstructor;
import lombok.Getter;
import lombok.NoArgsConstructor;
import lombok.Setter;

import javax.persistence.*;

@Getter
@Setter
@AllArgsConstructor
@NoArgsConstructor
@Entity
@Table(name = "CTPN_NGUYENLIEU")
public class CTPN_NguyenLieuEntity {
    @Id
    @GeneratedValue(strategy = GenerationType.IDENTITY)
    @Column(name = "IDCTPN")
    private Integer idCTPN;

    @Column(name = "SOLUONG")
    private int soLuong;

    @Column(name = "GIA")
    private int gia;

    @ManyToOne
    @JoinColumn(name = "MANL")
    private NguyenLieuEntity manl;

    @ManyToOne
    @JoinColumn(name = "IDPN")
    private PhieuNhapNguyenLieuEntity idpn;
}
