import { initializeApp } from 'firebase/app';
import { getFirestore } from 'firebase/firestore'

// TODO: Replace the following with your app's Firebase project configuration
const firebaseConfig = {
    apiKey: "AIzaSyAy63EGOEXf49xY0p0pJe3WaaGsdSf21ZI",
    authDomain: "trangquyen-shop.firebaseapp.com",
    databaseURL: "https://trangquyen-shop-default-rtdb.firebaseio.com",
    projectId: "trangquyen-shop",
    storageBucket: "trangquyen-shop.appspot.com",
    messagingSenderId: "660135097365",
    appId: "1:660135097365:web:1846be6946e85a8b588a1c",
    measurementId: "G-QYBV3619C3"
  };

export const app = initializeApp(firebaseConfig);
// MARK: Firestore Reference
export const db = getFirestore(app);