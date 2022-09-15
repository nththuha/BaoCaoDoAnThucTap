package com.example.ordermanagement.model

import com.squareup.moshi.Json

data class TableEntity(
    @Json(name = "maBan") val maBan: String,
    @Json(name = "tenBan") val tenBan: String,
    @Json(name = "soGhe") val soGhe: Int,
    @Json(name = "trangThai") val trangThai: String
)