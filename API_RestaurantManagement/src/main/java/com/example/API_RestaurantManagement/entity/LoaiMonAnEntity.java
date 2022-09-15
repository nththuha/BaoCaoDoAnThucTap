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
@Table(name = "LOAIMONAN")
public class LoaiMonAnEntity {
    @Id
    @Column(name = "MALMA")
    @Size(max = 10)
    private String maLMA;

    @Column(name = "TENLMA")
    @Size(max = 50)
    private String tenLMA;

    @Column(name = "HINHANH")
    @Size(max = 255)
    private String hinhAnh;

    @OneToMany(cascade = CascadeType.REFRESH, mappedBy = "malma")
    private List<MonAnEntity> monanList;
}
