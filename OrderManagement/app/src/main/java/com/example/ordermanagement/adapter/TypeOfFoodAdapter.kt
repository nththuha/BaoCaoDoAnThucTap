package com.example.ordermanagement.adapter

import android.view.LayoutInflater
import android.view.ViewGroup
import androidx.recyclerview.widget.DiffUtil
import androidx.recyclerview.widget.ListAdapter
import androidx.recyclerview.widget.RecyclerView
import com.example.ordermanagement.databinding.ItemTypeoffoodBinding
import com.example.ordermanagement.model.TypeOfFoodEntity

class TypeOfFoodAdapter(private val clickListener: (TypeOfFoodEntity) -> Unit) :
    ListAdapter<TypeOfFoodEntity, TypeOfFoodAdapter.TypeOfFoodEntityViewHolder>(DiffCallback) {
    override fun onCreateViewHolder(
        parent: ViewGroup,
        viewType: Int
    ): TypeOfFoodAdapter.TypeOfFoodEntityViewHolder {
        val viewHolder = TypeOfFoodEntityViewHolder(
            ItemTypeoffoodBinding.inflate(
                LayoutInflater.from(parent.context), parent, false
            )
        )
        viewHolder.itemView.setOnClickListener {
            val position = viewHolder.adapterPosition
            clickListener(getItem(position))
        }
        return viewHolder
    }

    override fun onBindViewHolder(
        holder: TypeOfFoodAdapter.TypeOfFoodEntityViewHolder,
        position: Int
    ) {
        val typeOfFood = getItem(position)
        holder.bind(typeOfFood)
    }

    class TypeOfFoodEntityViewHolder(private var binding: ItemTypeoffoodBinding) :
        RecyclerView.ViewHolder(binding.root) {
        fun bind(typeOfFood: TypeOfFoodEntity) {
            binding.typeOfFood = typeOfFood
            binding.executePendingBindings()
        }
    }

    companion object DiffCallback : DiffUtil.ItemCallback<TypeOfFoodEntity>() {
        override fun areItemsTheSame(
            oldItem: TypeOfFoodEntity,
            newItem: TypeOfFoodEntity
        ): Boolean {
            return oldItem.maLMA == newItem.maLMA
        }

        override fun areContentsTheSame(
            oldItem: TypeOfFoodEntity,
            newItem: TypeOfFoodEntity
        ): Boolean {
            return oldItem == newItem
        }
    }
}