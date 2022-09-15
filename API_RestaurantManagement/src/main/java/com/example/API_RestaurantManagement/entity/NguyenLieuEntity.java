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
@Table(name = "NGUYENLIEU")
public class NguyenLieuEntity {
    @Id
    @Column(name = "MANL")
    @Size(max = 10)
    private String maNL;

    @Column(name = "TENNL")
    @Size(max = 50)
    private String tenNL;

    @Column(name = "DONVI")
    @Size(max = 50)
    private String donVi;

    @OneToMany(cascade = CascadeType.REFRESH, mappedBy = "manl")
    private List<CT_MonAnEntity> ctMonanList;

    @OneToMany(cascade = CascadeType.REFRESH, mappedBy = "manl")
    private List<CTPN_NguyenLieuEntity> ctpnNguyenlieuList;
}
