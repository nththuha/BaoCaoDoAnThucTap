package com.example.ordermanagement.model

import com.squareup.moshi.Json

data class FoodEntity(
    @Json(name = "maMA") val maMA: String,
    @Json(name = "tenMA") val tenMA: String,
    @Json(name = "hinhAnh") val hinhAnh: String,
    @Json(name = "trangThai") val trangThai: String,
    @Json(name = "gia") val gia: Int
)
