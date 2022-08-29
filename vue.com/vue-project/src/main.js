import { createApp } from 'vue/dist/vue.esm-bundler.js'
import App from './App.vue'
import router from './router'

//import './assets/main.css'

// config
import PrimeVue from 'primevue/config';
import 'primevue/resources/themes/saga-blue/theme.css'       //theme
import 'primevue/resources/primevue.min.css '           //core css
import 'primeicons/primeicons.css'                      //icons

// componentes
import Dialog from 'primevue/dialog';
import InputText from 'primevue/inputtext';
import Button from 'primevue/button';
import TabMenu from 'primevue/tabmenu';
import DataTable from 'primevue/datatable';
import Column from 'primevue/column';
import ColumnGroup from 'primevue/columngroup';
import Row from 'primevue/row';
import Card from 'primevue/card';
import Badge from 'primevue/badge';
import InputNumber from 'primevue/inputnumber';
import Dropdown from 'primevue/dropdown';
import MultiSelect from 'primevue/MultiSelect';
import Calendar from 'primevue/Calendar';
import ProgressBar from 'primevue/ProgressBar';
import Slider from 'primevue/Slider';
import ToastService from 'primevue/toastservice';
import Rating from 'primevue/Rating';
import Textarea from 'primevue/Textarea';
import RadioButton from 'primevue/RadioButton';
import Toolbar from 'primevue/Toolbar';
import FileUpload from 'primevue/FileUpload';


const app = createApp(App)

app.use(router)
app.use(PrimeVue);
app.use(ToastService);

app.component('Dialog', Dialog);
app.component('InputText', InputText);
app.component('Button', Button);
app.component('TabMenu', TabMenu);
app.component('DataTable', DataTable);
app.component('Column', Column  );
app.component('ColumnGroup', ColumnGroup  );
app.component('Row', Row   );
app.component('Card', Card   );
app.component('Badge', Badge   );
app.component('InputNumber', InputNumber   );
app.component('Dropdown', Dropdown   );
app.component('MultiSelect', MultiSelect   );
app.component('Calendar', Calendar   );
app.component('ProgressBar', ProgressBar   );
app.component('Slider', Slider   );
app.component('Rating', Rating   );
app.component('Textarea', Textarea   );
app.component('RadioButton', RadioButton   ); 
app.component('Toolbar', Toolbar   ); 
app.component('FileUpload', FileUpload   ); 

app.mount('#app')