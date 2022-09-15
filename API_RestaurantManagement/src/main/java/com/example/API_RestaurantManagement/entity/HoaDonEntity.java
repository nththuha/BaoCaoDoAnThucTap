package com.example.API_RestaurantManagement.entity;

import lombok.AllArgsConstructor;
import lombok.Getter;
import lombok.NoArgsConstructor;
import lombok.Setter;
import org.springframework.format.annotation.DateTimeFormat;

import javax.persistence.*;
import javax.validation.constraints.Size;
import java.util.Date;
import java.util.List;

@Getter
@Setter
@AllArgsConstructor
@NoArgsConstructor
@Entity
@Table(name = "HOADON")
public class HoaDonEntity {
    @Id
    @Column(name = "MAHD")
    @Size(max = 50)
    private String maHD;

    @Column(name = "NGAY")
    @Temporal(TemporalType.DATE)
    @DateTimeFormat(pattern = "dd/MM/yyyy")
    private Date ngay;

    @Column(name = "TRIGIA")
    private int trigia;

    @Column(name = "GIASAUTHUE")
    private int giaSauThue;

    @Column(name = "MASOTHUE")
    @Size(max = 50)
    private String masothue;

    @Column(name = "HOTENKH")
    @Size(max = 50)
    private String hotenkh;

    @OneToMany(cascade = CascadeType.ALL, mappedBy = "mahd")
    private List<PhieuDatEntity> phieudatList;

    @ManyToOne
    @JoinColumn(name = "IDNV")
    private NhanVienEntity idnv;
}
