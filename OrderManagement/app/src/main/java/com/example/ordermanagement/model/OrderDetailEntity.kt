package com.example.ordermanagement.model

import com.squareup.moshi.Json

data class OrderDetailEntity(
    @Json(name = "idCTDM") val idCTDM: Int,
    @Json(name = "soLuong") val soLuong: Int,
    @Json(name = "chuThich") val chuThich: String?,
    @Json(name = "trangThai") val trangThai: String,
    @Json(name = "gia") val gia: Int,
    @Json(name = "mama") val maMA: String,
    @Json(name = "tenma") val tenMA: String?,
    @Json(name = "malma") val maLMA: String?,
    @Json(name = "idpd") val idPD: Int,
    @Json(name = "tenPhong") val tenPhong: String?,
    @Json(name = "tenBan") val tenBan: String?,
)