package com.example.API_RestaurantManagement.entity;

import lombok.AllArgsConstructor;
import lombok.Getter;
import lombok.NoArgsConstructor;
import lombok.Setter;

import javax.persistence.*;
import javax.validation.constraints.Size;

@Getter
@Setter
@AllArgsConstructor
@NoArgsConstructor
@Entity
@Table(name = "CT_DATMON")
public class CT_DatMonEntity {
    @Id
    @GeneratedValue(strategy = GenerationType.IDENTITY)
    @Column(name = "IDCTDM")
    private Integer idCTDM;

    @Column(name = "SOLUONG")
    private int soLuong;

    @Column(name = "CHUTHICH")
    @Size(max = 255)
    private String chuThich;

    @Column(name = "TRANGTHAI")
    @Size(max = 50)
    private String trangThai;

    @Column(name = "GIA")
    private int gia;

    @ManyToOne
    @JoinColumn(name = "MAMA")
    private MonAnEntity mama;

    @ManyToOne
    @JoinColumn(name = "IDPD")
    private PhieuDatEntity idpd;
}
