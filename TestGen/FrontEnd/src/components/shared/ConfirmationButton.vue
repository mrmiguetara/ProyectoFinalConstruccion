<template>
    <transition name="fade">
        <button :class="classes" v-click-outside="outsideClick" @click="btnClick">
           {{confirmText}} <slot></slot>
        </button>
    </transition>
</template>

<script>
    import ClickOutside from 'vue-click-outside';
    export default {
        name: 'confirmation-button',
        props: ['className', 'outline'],
        data(){
            return {
                confirming: false
            };
        },
        computed: {
            classes(){
                let value = this.confirming ? 'danger': 'secondary';
                let result = this.outline ? `btn-outline-${value}` : `btn-${value}`;
                return `btn ${result} ${this.className}`;
            },
            confirmText(){
                return this.confirming ? 'Confirm ' : '';
            }
        },
        methods: {
           btnClick(){
               if(this.confirming){
                   this.$emit('confirmed');
                   this.outsideClick();
               }else {
                   this.confirming = true;
               }
           },
            outsideClick(){
               this.confirming = false;
            }
        },
        directives: {
            ClickOutside
        }
    }
</script>