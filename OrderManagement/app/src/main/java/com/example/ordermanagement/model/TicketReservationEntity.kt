package com.example.ordermanagement.model

import com.squareup.moshi.Json

data class TicketReservationEntity(
    @Json(name = "idPD") val idPD: Int,
    @Json(name = "ngay") val ngay: String,
    @Json(name = "idnv") val idnv: Int,
    @Json(name = "maBan") val maBan: String?,
    @Json(name = "tenBan") val tenBan: String?,
    @Json(name = "maPhong") val maPhong: String?,
    @Json(name = "tenPhong") val tenPhong: String?,
)