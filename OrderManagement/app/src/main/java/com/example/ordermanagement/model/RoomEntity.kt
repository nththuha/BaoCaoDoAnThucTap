package com.example.ordermanagement.model

import com.squareup.moshi.Json

data class RoomEntity(
    @Json(name = "maPhong") val maPhong: String,
    @Json(name = "tenPhong") val tenPhong: String,
    @Json(name = "trangThai") val trangThai: String
)