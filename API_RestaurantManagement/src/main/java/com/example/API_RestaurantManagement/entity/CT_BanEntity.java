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
@Table(name = "CT_BAN")
public class CT_BanEntity {
    @Id
    @GeneratedValue(strategy = GenerationType.IDENTITY)
    @Column(name = "IDCTB")
    private Integer idCTB;

    @Column(name = "TRANGTHAI")
    @Size(max = 50)
    private String trangThai;

    @Column(name = "SOGHE")
    private Integer soGhe;

    @ManyToOne
    @JoinColumn(name = "MABAN")
    private BanEntity maban;

    @ManyToOne
    @JoinColumn(name = "MAPHONG")
    private PhongEntity maphong;

    @OneToMany(cascade = CascadeType.REFRESH, mappedBy = "idctb")
    private List<CT_DatBanEntity> ctDatBanList;
}
