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
@Table(name = "MONAN")
public class MonAnEntity {
    @Id
    @Column(name = "MAMA")
    @Size(max = 10)
    private String maMA;

    @Column(name = "TENMA")
    @Size(max = 50)
    private String tenMA;

    @Column(name = "CHUTHICH")
    @Size(max = 255)
    private String chuThich;

    @Column(name = "TRANGTHAI")
    @Size(max = 50)
    private String trangThai;

    @Column(name = "HINHANH")
    @Size(max = 255)
    private String hinhAnh;

    @OneToMany(cascade = CascadeType.REFRESH, mappedBy = "mama")
    private List<CT_DatMonEntity> ctDatmonList;

    @OneToMany(cascade = CascadeType.REFRESH, mappedBy = "mama")
    private List<CT_MonAnEntity> ctMonanList;

    @OneToMany(cascade = CascadeType.REFRESH, mappedBy = "mama")
    private List<ThayDoiGiaMonEntity> thaydoigiamonList;

    @ManyToOne
    @JoinColumn(name = "MALMA")
    private LoaiMonAnEntity malma;
}
