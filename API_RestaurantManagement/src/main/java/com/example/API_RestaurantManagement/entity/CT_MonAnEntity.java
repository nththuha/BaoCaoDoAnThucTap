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
@Table(name = "CT_MONAN")
public class CT_MonAnEntity {
    @Id
    @GeneratedValue(strategy = GenerationType.IDENTITY)
    @Column(name = "IDCTMA")
    private Integer idCTMA;

    @Column(name = "SOLUONG")
    private int soLuong;

    @ManyToOne
    @JoinColumn(name = "MAMA")
    private MonAnEntity mama;

    @ManyToOne
    @JoinColumn(name = "MANL")
    private NguyenLieuEntity manl;
}
