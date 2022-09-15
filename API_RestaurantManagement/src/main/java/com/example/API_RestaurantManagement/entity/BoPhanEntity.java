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
@Table(name = "BOPHAN")
public class BoPhanEntity {
    @Id
    @Column(name = "MABP")
    @Size(max = 10)
    private String maBP;

    @Column(name = "TENBP")
    @Size(max = 50)
    private String tenBP;

    @OneToMany(cascade = CascadeType.REFRESH, mappedBy = "mapb")
    private List<NhanVienEntity> nhanVienList;
}