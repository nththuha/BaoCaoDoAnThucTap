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
@Table(name = "BAN")
public class BanEntity {
    @Id
    @Column(name = "MABAN")
    @Size(max = 10)
    private String maBan;

    @Column(name = "TENBAN")
    @Size(max = 50)
    private String tenBan;

    @Column(name = "SOGHE")
    private Integer soGhe;

    @OneToMany(cascade = CascadeType.REFRESH, mappedBy = "maban")
    private List<CT_BanEntity> ctBanList;
}
