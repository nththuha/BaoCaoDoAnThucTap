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
@Table(name = "PHONG")
public class PhongEntity {
    @Id
    @Column(name = "MAPHONG")
    @Size(max = 10)
    private String maPhong;

    @Column(name = "TENPHONG")
    @Size(max = 50)
    private String tenPhong;

    @OneToMany(cascade = CascadeType.REFRESH, mappedBy = "maphong")
    private List<CT_BanEntity> ctBanList;
}
