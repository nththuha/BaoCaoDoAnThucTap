package com.example.ordermanagement.adapter

import android.view.LayoutInflater
import android.view.ViewGroup
import androidx.recyclerview.widget.DiffUtil
import androidx.recyclerview.widget.ListAdapter
import androidx.recyclerview.widget.RecyclerView
import com.example.ordermanagement.R
import com.example.ordermanagement.databinding.ItemFoodBinding
import com.example.ordermanagement.model.FoodEntity
import java.text.DecimalFormat

class FoodAdapter(private val clickListener: (FoodEntity) -> Unit) :
    ListAdapter<FoodEntity, FoodAdapter.FoodEntityViewHolder>(DiffCallback) {
    override fun onCreateViewHolder(
        parent: ViewGroup,
        viewType: Int
    ): FoodAdapter.FoodEntityViewHolder {
        val viewHolder = FoodEntityViewHolder(
            ItemFoodBinding.inflate(
                LayoutInflater.from(parent.context), parent, false
            )
        )
        viewHolder.itemView.setOnClickListener {
            val position = viewHolder.adapterPosition
            clickListener(getItem(position))
        }
        return viewHolder
    }

    override fun onBindViewHolder(holder: FoodAdapter.FoodEntityViewHolder, position: Int) {
        val food = getItem(position)
        holder.bind(food)
    }

    class FoodEntityViewHolder(private var binding: ItemFoodBinding) :
        RecyclerView.ViewHolder(binding.root) {
        fun bind(food: FoodEntity) {
            if (food.trangThai != "In stock" || food.gia == 0) {
                binding.clFood.isEnabled = false
                binding.clFood.setBackgroundResource(R.drawable.ticket_click_true)
            }
            val dec = DecimalFormat("#,###.##")
            val money = dec.format(food.gia) + "VND"
            binding.tvGia.text = money
            binding.food = food
            binding.executePendingBindings()
        }
    }

    companion object DiffCallback : DiffUtil.ItemCallback<FoodEntity>() {
        override fun areItemsTheSame(oldItem: FoodEntity, newItem: FoodEntity): Boolean {
            return oldItem.maMA == newItem.maMA
        }

        override fun areContentsTheSame(oldItem: FoodEntity, newItem: FoodEntity): Boolean {
            return oldItem == newItem
        }
    }
}