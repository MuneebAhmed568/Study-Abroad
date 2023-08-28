import { createRouter, createWebHistory } from 'vue-router'
import HomeView from '../views/HomeView.vue'
import Blog from "../views/BlogView.vue"
import BlogPage from "../views/SingleBlogPage.vue"
import AboutUs from "../views/AboutUsView.vue"
import NewsView from '../views/NewsView.vue'
import NewsPage from '../views/SingleNewsPage.vue'
import ScholarshipView from '../views/ScholarshipView.vue'
import ScholarshipPage from '../views/SingleScholarshipPage.vue'
import ConsultantView from '../views/ConsultantView.vue'
import ConsultantPage from '../views/SingleConsultantPage.vue'
import PageNotFound from '../views/PageNotFound.vue'
import FormLink from '../views/FormLinkView.vue'
import CoursesView from '../views/CoursesView.vue'
import Guide from '../views/GuideView.vue'
import GuidePage from '../views/GuidePageView.vue'
import StudyAds from '../views/StudyAdsView'
import StudyAdsPage from '../views/SingleStudyAdsPage'
import Embassy from '../views/EmbassyView'
import EmbassyPage from '../views/SingleEmbassyPage'
import faqs from '../views/FAQSView.vue'
import videos from '../views/VideosView.vue'
import University from '../views/ViewUniverisity.vue'
import UniversityPage from '../views/SingleUniversityPage.vue'
import UniView from '../views/UniversityView.vue'
import Ads from '../components/YourAds.vue'
import Test from '../views/TestsView.vue'
import TestPage from '../views/SingleTestPage.vue'
import StudentDashboard from '../views/StudentDashboard.vue'
import Portal from '../views/PortalManagement.vue'


//import MyProfile from '../components/MyProfile.vue'
//import ComProfile from '../components/CompanyProfile.vue'
import Admins from '../views/AdminView.vue'
const routes = [{
        path: '/',
        name: '/',
        component: HomeView,
        meta: {
            title: "AbroadStudy/Home",
            requiresAuth: false
        }
    },
    {
        path: '/portal',
        name: 'portal',
        component: Portal,
        meta: {
            title: "AbroadStudy/Portal",
            requiresAuth: false
        }
    },
    {
        path: '/blog',
        name: 'blog',
        component: Blog,
        meta: {
            title: "AbroadStudy/Blog",
            requiresAuth: false
        }
    },

    {
        path: '/blogs:Id',
        name: 'blogpage',
        component: BlogPage,
        meta: {
            title: "AbroadStudy/BlogPage",
            requiresAuth: false
        }
    },
    {
        path: '/consultantportal',
        name: '/consultant',
        component: Admins,
        meta: {
            title: "AbroadStudy/Consultant Dashboard",
            requiresAuth: true
        }
    },
    {
        path: '/ads',
        name: '/ads',
        component: Ads,
        meta: {
            title: "AbroadStudy/StudyAds",
        }
    },
    {
        path: '/aboutus',
        name: '/aboutus',
        component: AboutUs,
        meta: {
            title: "AbroadStudy/AboutUs",
        }
    },
    {
        path: '/news',
        name: '/news',
        component: NewsView,
        meta: {
            title: "AbroadStudy/News",
        }
    },
    {
        path: '/newsPage:emailid',
        name: '/newsPage',
        component: NewsPage,
        meta: {
            title: "AbroadStudy/News",
        }
    },
    {
        path: '/scholarshipPage:ID',
        name: 'scholarshipPage',
        component: ScholarshipPage,
        meta: {
            title: "AbroadStudy/Scholarship",
        }
    }

    ,
    {
        path: '/Universitys',
        name: '/Universitys',
        component: UniView,
        meta: {
            title: "AbroadStudy/University Dashboard",
            requiresAuth: true
        }
    },
    {
        path: '/universitypage:emailid',
        name: '/universitypage',
        component: UniversityPage,
        meta: {
            title: "AbroadStudy/Universities",
        }
    },
    {
        path: '/:pathMatch(.*)*',
        name: 'notFound',
        component: PageNotFound,
        meta: {
            title: "AbroadStudy/PageNotFound",
        }
    },

    {
        path: '/form',
        name: 'form',
        component: FormLink,
        meta: {
            title: "AbroadStudy/FormLink",
        }
    },

    // {
    //     path: '/*',
    //     name: 'notFound',
    //     component: PageNotFound,
    //     meta: {
    //         title: "AbroadStudy/PageNotFound",
    //     }
    // },

    {
        path: '/ConsultantPage:idconsult',
        name: 'ConsultantPage',
        component: ConsultantPage,
        meta: {
            title: "AbroadStudy/Consultant",
        }
    },
    {
        path: '/scholarship',
        name: '/scholarship',
        component: ScholarshipView,
        meta: {
            title: "AbroadStudy/Scholarship",
        }

    },
    {
        path: '/university',
        name: '/university',
        component: University,
        meta: {
            title: "AbroadStudy/University",
        }
    },
    {
        path: '/Consultant',
        name: '/Consultant',
        component: ConsultantView,
        meta: {
            title: "AbroadStudy/Consultant",
        }
    },
    {
        path: '/courses',
        name: '/courses',
        component: CoursesView,
        meta: {
            title: "AbroadStudy/Courses",
        }
    },
    {
        path: '/guide',
        name: '/guide',
        component: Guide,
        meta: {
            title: "AbroadStudy/Guide",
        }
    },
    {
        path: '/guidePage:idguide',
        name: 'guidePage',
        component: GuidePage,
        meta: {
            title: "AbroadStudy/Guide",
        }
    },
    {
        path: '/studyads',
        name: '/studyads',
        component: StudyAds,
        meta: {
            title: "AbroadStudy/Study Ads",
        }
    },
    {
        path: '/studyadspage',
        name: '/studyadspage',
        component: StudyAdsPage,
        meta: {
            title: "AbroadStudy/Study Ads",
        }
    },
    {
        path: '/embassy',
        name: '/embassy',
        component: Embassy,
        meta: {
            title: "AbroadStudy/Embassy",
        }
    },
    {
        path: '/embassypage',
        name: '/embassypage',
        component: EmbassyPage,
        meta: {
            title: "AbroadStudy/Embassy",
        }
    },
    {
        path: '/faqs',
        name: '/faqs',
        component: faqs,
        meta: {
            title: "AbroadStudy/FAQs",
        }
    },
    {
        path: '/test',
        name: '/test',
        component: Test,
        meta: {
            title: "AbroadStudy/Test Information",
        }
    },
    {
        path: '/testpage:name',
        name: '/testpage',
        component: TestPage,
        meta: {
            title: "AbroadStudy/Test Information",
        }
    },
    {
        path: '/videos',
        name: '/videos',
        component: videos,
        meta: {
            title: "AbroadStudy/Videos",
        }
    },
    {
        path: '/studentdashboard',
        name: '/studentdashboard',
        component: StudentDashboard,
        meta: {
            title: "AbroadStudy/Student Dashboard",
            requiresAuth: true,
        }
    }
]

const router = createRouter({
    history: createWebHistory(process.env.BASE_URL),
    mode: "history",
    routes,
    scrollBehavior() {
        document.getElementById('app').scrollIntoView({ behavior: 'smooth' });
    }
})
router.beforeEach((to, from, next) => {
    document.title = `${to.meta.title}`;
    next();
    // if (to.matched.some((record) => record.meta.requiresAuth)) {
    //   if (!(this.auth.isAuthenticated())) {
    //     router.push({ path: '/', name: '/', component: HomeView })
    //   }
    // } else {
    //   document.title= `${to.meta.title}`;
    //   next()
    // }
});

export default router