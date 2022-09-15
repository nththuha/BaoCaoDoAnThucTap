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
@Table(name = "KHACHHANG")
public class KhachHangEntity {
    @Id
    @Column(name = "IDKH")
    @GeneratedValue(strategy = GenerationType.IDENTITY)
    private Integer idKH;

    @Column(name = "HOTEN")
    @Size(max = 50)
    private String hoTen;

    @Column(name = "SDT")
    @Size(max = 50)
    private String sDT;

    @OneToMany(cascade = CascadeType.REFRESH, mappedBy = "idkh")
    private List<PhieuDatEntity> phieudatList;

}
