package com.example.ordermanagement.model

import com.squareup.moshi.Json

data class TypeOfFoodEntity(
    @Json(name = "maLMA") val maLMA: String,
    @Json(name = "tenLMA") val tenLMA: String,
    @Json(name = "hinhAnh") val hinhAnh: String
)
